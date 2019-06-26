using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCar.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyCar.ViewModel;
using Plugin.Media;
using Plugin.Media.Abstractions;


namespace MyCar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateEditCar : ContentPage
	{
        private CreateEditCarViewModel _viewModel;

        public CreateEditCar()
        {
            InitializeComponent();

            _viewModel = new CreateEditCarViewModel();
            BindingContext = _viewModel;

            pickPhoto.Clicked += async (sender, args) =>
            {
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
                    return;
                }
                var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,

                });


                if (file == null)
                    return;

                _viewModel.ImageSource = file.Path;
               
            };


        }

        public CreateEditCar(Vehicle vehicle)
        {
            InitializeComponent();
            _viewModel = new CreateEditCarViewModel();
            BindingContext = _viewModel;
            _viewModel.CarModel = vehicle.Model;
            _viewModel.CarName = vehicle.Name;

        }


        private async void AddVehicle_Clicked(object sender, EventArgs e)
        {

            await App.LocalDB.SaveItemAsync(new Vehicle()
            {
                Name = _viewModel.CarName,
                Model = _viewModel.CarModel,
                DateOfCreation = new DateTime(1989, 5, 19),
                ImageSrc = _viewModel.ImageSource
            }
            );

            await Navigation.PushAsync(new History());
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new History());
        }
    }
}