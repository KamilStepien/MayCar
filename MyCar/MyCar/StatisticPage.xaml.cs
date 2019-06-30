using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCar.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StatisticPage : ContentPage
	{
        private StatisticViewModel _view = new StatisticViewModel();

        public StatisticPage ()
		{
            BindingContext = _view;
			InitializeComponent ();
		}

        protected async override  void OnAppearing()
        {
            double allLitrPetrol = 0;
            double allNumberOFKm = 0;
            TimeSpan allRidesHour = new TimeSpan(0, 0, 0);
            var vehicles = await App.LocalDB.GetVehicles();
            var petrol = await App.LocalDB.GetPetrol();
            var trip = await App.LocalDB.GetTrip();
            var drive = await App.LocalDB.GetDrive();

            _view.Vehicle = vehicles.Count;

            foreach(var elm in petrol)
            {
                allLitrPetrol += (elm.Price * elm.PricePerLiter);
               
            }

            _view.AllLitrPetrol = allLitrPetrol;


            foreach (var elm in trip)
            {
                allNumberOFKm += elm.NumberOfKm;
               
            }


            foreach (var elm in drive)
            {
                allNumberOFKm += elm.NumberOfKm;
                allRidesHour += elm.timeSpan;
            }
            _view.AllNumberOFKm = allNumberOFKm;
            _view.AllRidesHour = allRidesHour.ToString();

        }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}