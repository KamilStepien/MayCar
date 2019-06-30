using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCar.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyCar.Model;

namespace MyCar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateTripPage : ContentPage
	{
        private CreateTripViewModel _view = new CreateTripViewModel();
		public CreateTripPage ()
		{
            
			InitializeComponent ();
            BindingContext = _view;
            

        }

        private async void AddTrip_Clicked(object sender, EventArgs e)
        {
            if(_view.TripName != "" && _view.TripDestination != "" && _view.TripStartPoint != "" && _view.TripNumberOfKm != 0)
            {
                Trip tripTmp = new Trip()
                {
                    Nazwa = _view.TripName,
                    NumberOfKm = _view.TripNumberOfKm,
                    Destination = _view.TripDestination,
                    StartPoint = _view.TripStartPoint,
                    Date = DateTime.Now,
                    Start = DateTime.Now
                };

                await App.LocalDB.SaveItemAsync(tripTmp);

                await App.LocalDB.SaveItemAsync(new HistorySQL()
                {
                    Typ = "trip",
                    IdClass = tripTmp.Id

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