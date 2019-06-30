using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.ViewModel
{
    class FillUpViewModel:BaseViewModel
    {
        List<string> _typOfPetrol = new List<string>();
        DateTime _currentDate;
        DateTime _selectDate;
        string _selectedPetrol;
        private double _price;
        private double _pricePerLiter;

        private string _errorMessage = "Nie uzupełniono wszystkich pól";
        private bool _errorMessageIsVisible = false;



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



        public FillUpViewModel()
        {
          
   
        }

       

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    RaisePropertyChanged(nameof(Price));
                }
            }
        }

        public string SelectedPetrol
        {
            get { return _selectedPetrol; }
            set
            {
                if (_selectedPetrol != value)
                {
                    _selectedPetrol = value;
                    RaisePropertyChanged(nameof(SelectedPetrol));
                }
            }
        }




        public double PricePerLiter
        {
            get { return _pricePerLiter; }
            set
            {
                if (_pricePerLiter != value)
                {
                    _pricePerLiter = value;
                    RaisePropertyChanged(nameof(PricePerLiter));
                }
            }
        }




        public DateTime CurrentDate
        {
            get { return _currentDate; }
            set
            {
                if (_currentDate != value)
                {
                    _currentDate = value;
                    RaisePropertyChanged(nameof(CurrentDate));
                }
            }
        }

     
        public DateTime SelectDate
        {
            get { return _selectDate; }
            set
            {
                if (_selectDate != value)
                {
                    _selectDate = value;
                    RaisePropertyChanged(nameof(SelectDate));
                }
            }
        }

        public List<string> TypOfPetrol
        {
            get
            { 
                return _typOfPetrol;
            }
            set
            {
                if (_typOfPetrol != value)
                {
                    _typOfPetrol = value;
                    RaisePropertyChanged(nameof(TypOfPetrol));
                }
            }

        }

    }
}
