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
        private int vehicleId;
        public CreateEditCar()
        {
            InitializeComponent();

            _viewModel = new CreateEditCarViewModel();
            BindingContext = _viewModel;

            _viewModel.CurrentDateTime = DateTime.Now;
            _viewModel.IsEddit = false;




        }

        public CreateEditCar(Vehicle vehicle)
        {
            InitializeComponent();
            _viewModel = new CreateEditCarViewModel();
            BindingContext = _viewModel;
            _viewModel.IsEddit = true;
            _viewModel.CarModel = vehicle.Model;
            _viewModel.CarMark = vehicle.Marka;
            _viewModel.CarName = vehicle.Name;
            _viewModel.ImageSource = vehicle.ImageSrc;
            _viewModel.DateOfCreation = vehicle.DateOfCreation;
            _viewModel.EndCarInsurance = vehicle.EndCarInsurance;
            _viewModel.EndCarReview = vehicle.EndCarReview;
            _viewModel.FuelTank = vehicle.FuelTank;
            _viewModel.LonHundredtKm = vehicle.LonHundredtKm;
            vehicleId = vehicle.Id;


        }


        private async void AddVehicle_Clicked(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(_viewModel.CarModel) && string.IsNullOrWhiteSpace(_viewModel.CarMark)&& string.IsNullOrWhiteSpace(_viewModel.CarName)   )
            {
                _viewModel.ErroMessagIsVisible = true;
            }
            else
            {
                await App.LocalDB.SaveItemAsync(new Vehicle()
                {
                    Id = vehicleId,
                    Name = _viewModel.CarName,
                    Model = _viewModel.CarModel,
                    Marka = _viewModel.CarMark,
                    FuelTank = _viewModel.FuelTank,
                    LonHundredtKm = _viewModel.LonHundredtKm,
                    EndCarReview = _viewModel.EndCarReview,
                    EndCarInsurance = _viewModel.EndCarInsurance,
                    DateOfCreation =  DateTime.Now,
                    ImageSrc = _viewModel.ImageSource
                }
            );

                await Navigation.PushAsync(new MainPage());
            }
          
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());
        }

        private async void pickPhoto(object sender, EventArgs e)
        {

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Brak dostepu do galeri ", ":( Przepraszamy z utrudnienia.", "OK");
                return;
            }
            var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,

            });


            if (file == null)
                return;

            _viewModel.ImageSource = file.Path;

        }

        private async void takePhoto(object sender, EventArgs e)
        {

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Brak Kamery", ":( Nie ma dostępu do aparatu.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;


            _viewModel.ImageSource = file.Path;
        }
    }
}