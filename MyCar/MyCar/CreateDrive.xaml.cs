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
		public CreateDrive ()
		{
			InitializeComponent ();
            BindingContext = _view;


            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
             {
                 Device.BeginInvokeOnMainThread(() =>
                 {
                     _view.Seconds = App.StopWatch.Elapsed.Seconds;
                 });
                 return true;
             });
        }

        

        private void Start(object sender, EventArgs e)
        {

            App.StopWatch.Start();
           
        }

        private void Stop(object sender, EventArgs e)
        {
            App.StopWatch.Stop();
           
        }
    }
}