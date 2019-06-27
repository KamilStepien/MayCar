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
	public partial class Cars : ContentPage
	{
        public CarsViewModel _view = new CarsViewModel();
		public Cars ()
		{
			InitializeComponent ();
            BindingContext = _view;
		}

        protected override async void OnAppearing()
        {
            var vehicles = await App.LocalDB.GetVehicles();
            _view.Vehicles = vehicles;
            lvCars.ItemTapped -= lvCars_ItemTapped;
            lvCars.ItemTapped += lvCars_ItemTapped;
        }

        private async void lvCars_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vehicle = (Vehicle)e.Item;
            var dbVehicle = await App.LocalDB.GetVehicleById(vehicle.Id);
            await Navigation.PushAsync(new CarsDetailsPage(dbVehicle));
        }

        private async void AddCar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateEditCar());
        }
    }
}