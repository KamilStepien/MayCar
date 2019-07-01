using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyCar.ViewModel;
namespace MyCar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateDrive : ContentPage
	{
        private CreateDriveViewModel _view = new CreateDriveViewModel();
        private DateTime start;
        private DateTime end;
		public CreateDrive ()
		{
			InitializeComponent ();
            BindingContext = _view;


            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
             {
                 Device.BeginInvokeOnMainThread(() =>
                 {
                     _view.Time = App.StopWatch.Elapsed;
                 });
                 return true;
             });
        }

        

        private void Start(object sender, EventArgs e)
        {
            App.StopWatch.Reset();
            start = DateTime.Now;
            App.StopWatch.Start();
           
        }

        private void SaveDrive(object sender, EventArgs e)
        {
            end = DateTime.Now;
            Navigation.PushAsync(new DriveAddOtherInformationsPage(_view.Time , start , end));
            App.StopWatch.Reset();

        }

        private void Stop(object sender, EventArgs e)
        {
            end = DateTime.Now;
            App.StopWatch.Stop();
           
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}