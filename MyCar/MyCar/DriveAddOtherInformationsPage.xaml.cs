using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCar.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyCar.ViewModel;
namespace MyCar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DriveAddOtherInformationsPage : ContentPage
	{
        private TimeSpan _time;
        private DateTime _start;
        private DateTime _end;
        private DriveAddOtherInformationsViewModel _view = new DriveAddOtherInformationsViewModel();
        
		public DriveAddOtherInformationsPage (TimeSpan time , DateTime start , DateTime end)
		{
			InitializeComponent ();
            BindingContext = _view;
            _view.ErrorMessageIsVisible = false;
            _time = time;
            _start = start;
            _end = end;
        }

        private async void CreateDrive(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(_view.TripName) && string.IsNullOrWhiteSpace(_view.TripStartPoint) )
            {
                _view.ErrorMessageIsVisible = true;
            }
            else
                {
                Drive driveTmp = new Drive()
                {
                    Nazwa = _view.TripName,
                    NumberOfKm = _view.TripNumberOfKm,
                    StartPoint =  _view.TripStartPoint,
                    timeSpan = _time,
                    StartTime = _start,
                    EndTime = _end,
                    Date = DateTime.Now,
                };

                await App.LocalDB.SaveItemAsync(driveTmp);


                await App.LocalDB.SaveItemAsync(new HistorySQL()
                {
                    Typ = "drive",
                    IdClass = driveTmp.Id

                });

                await Navigation.PushAsync(new MainPage());
            }


          
        }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}