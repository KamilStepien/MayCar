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
	public partial class PetrolCalculator : ContentPage
	{

        private PetrolCalculatorViewModel _viewModel;

        public PetrolCalculator ()
		{
			InitializeComponent ();
            _viewModel = new PetrolCalculatorViewModel();
            BindingContext = _viewModel;

            
            
           


        }


         private  void Label_TextChanged(object sender, TextChangedEventArgs e)
        {
            double averageCombustion;
            double priceOfPetrol;
            double numberOfKilometer;
            double addedCost;


            if(Double.TryParse(entryNumberOfKilometer.Text , out numberOfKilometer) && Double.TryParse(entryAddedCost.Text, out addedCost) && Double.TryParse(entryAverageCombustion.Text, out averageCombustion) && Double.TryParse(entryPriceOfPetrol.Text, out priceOfPetrol))
            {
                _viewModel.ErroMessagIsVisible = false;
                _viewModel.PriceOfPetrol = ((((averageCombustion * priceOfPetrol)/ 100)* numberOfKilometer) +addedCost ).ToString();
            }
            else
            {
                _viewModel.ErroMessagIsVisible = true;
                _viewModel.PriceOfPetrol = "";
            }

        }
    }
}