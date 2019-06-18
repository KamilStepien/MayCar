using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCar.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateEditCar : ContentPage
	{
		public CreateEditCar ()
		{
			InitializeComponent ();
		}


        private async void AddVehicle_Clicked(object sender, EventArgs e)
        {
            var vehicle = await App.LocalDB.GetItemsAsync<Vehicle>();
            await DisplayAlert("Auta", $"Liczba Aut w bazie: {vehicle.Count}", "OK");

            await App.LocalDB.SaveItemAsync(new Vehicle()
            {
                Name = Name.Text,
                Model = Model.Text,
                DateOfCreation = new DateTime(1989, 5, 19)
            }
            );

            await Navigation.PushAsync(new MainPage());
        }
    }
}