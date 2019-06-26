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
	public partial class FillUpPage : ContentPage
	{
        private FillUpViewModel _viewModel = new FillUpViewModel();
        private List<string> _typOfPetrol = new List<string>();
        public FillUpPage ()
		{
			InitializeComponent ();
            BindingContext = _viewModel;
            _typOfPetrol.Add("Bezyna");
            _typOfPetrol.Add("Ropa");
            _typOfPetrol.Add("LPG");
            _viewModel.TypOfPetrol = _typOfPetrol;
        }

        
        private async void Add(object sender, EventArgs e)
        {
            var petrol = await App.LocalDB.GetItemsAsync<Petrol>();
            await DisplayAlert("Auta", $"Liczba zapisanych tankowań: {petrol.Count}", "OK");

            if( _viewModel.Price != "" && _viewModel.PricePerLiter != "" && _viewModel.SelectedPetrol != "") 
            {
                await App.LocalDB.SaveItemAsync(new Petrol()
                {
                    TypeOfPetrol = _viewModel.SelectedPetrol,
                    Price = Convert.ToDouble(_viewModel.Price),
                    PricePerLiter = Convert.ToDouble(_viewModel.PricePerLiter),
                    DateOfCreation = _viewModel.SelectDate
                }
                );
                _viewModel.ErroMessagIsVisible = false;
                _viewModel.SelectedPetrol = "";
                _viewModel.Price = "";
                _viewModel.PricePerLiter = "";

              

            }
            else
            {
                _viewModel.ErroMessagIsVisible = true;

            }

            

            
        }
    }
}