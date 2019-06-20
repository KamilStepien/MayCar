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

            _viewModel.PriceOfPetrol = "10";
            
           


        }


         private  void Label_TextChanged(object sender, TextChangedEventArgs e)
        {
            var averageCombustion = entryAverageCombustion?.Text;
            var priceOfPetrol = entryPriceOfPetrol?.Text;
            var numberOfKilometer = entryNumberOfKilometer?.Text;
            var addedCost = entryAddedCost?.Text;


            if(averageCombustion != null && priceOfPetrol != null && numberOfKilometer != null && averageCombustion != "" && priceOfPetrol != "" && numberOfKilometer != "" )
            {
                _viewModel.ErroMessagIsVisible = false;
                _viewModel.PriceOfPetrol = (((Convert.ToDouble(averageCombustion) * Convert.ToDouble(priceOfPetrol)) / 100) * Convert.ToDouble(numberOfKilometer)+ ((addedCost is null || addedCost == "") ?0: Convert.ToDouble(addedCost))).ToString();
            }
            else
            {
                _viewModel.ErroMessagIsVisible = true;
                _viewModel.PriceOfPetrol = "";
            }

        }
    }
}