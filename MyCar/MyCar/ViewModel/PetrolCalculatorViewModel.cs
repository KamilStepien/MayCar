using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCar.ViewModel
{
    public class PetrolCalculatorViewModel : BaseViewModel
    {

        private string _errorMessage = "Nie uzupełniono wszystkich pól";
        private bool _errorMessageIsVisible = false;
        private string _priceOfPetrol;
        

        public string ErrorMessage => _errorMessage;
     


        public bool ErroMessagIsVisible
        {
            get
            {
                return _errorMessageIsVisible;
            }
            set
            {
                if (_errorMessageIsVisible != value)
                {
                    _errorMessageIsVisible = value;
                    RaisePropertyChanged(nameof(ErroMessagIsVisible));
                }
            }
        }



        public string PriceOfPetrol
        {
            get
            {
                return $"Koszt dojazdu: {_priceOfPetrol} zł" ;
            }
            set
            {
                if (_priceOfPetrol != value)
                {
                    _priceOfPetrol = value;
                    RaisePropertyChanged(nameof(PriceOfPetrol));
                }
            }
        }

    }
}
