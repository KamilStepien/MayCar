using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.ViewModel
{
    class FillUpViewModel:BaseViewModel
    {
        List<string> _typOfPetrol = new List<string>();
        DateTime _miniDate;
        DateTime _maxDate;
        DateTime _selectDate;
        string _selectedPetrol;
        string _price;
        string _pricePerLiter;

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
            ErroMessagIsVisible = false;
            MaxDate = DateTime.Now;
            MiniDate = MaxDate.AddDays(-7);
        }

       

        public string Price
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




        public string PricePerLiter
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




        public DateTime MaxDate
        {
            get { return _maxDate; }
            set
            {
                if (_maxDate != value)
                {
                    _maxDate = value;
                    RaisePropertyChanged(nameof(MaxDate));
                }
            }
        }

        public DateTime MiniDate
        {
            get { return _miniDate; }
            set
            {
                if (_miniDate != value)
                {
                    _miniDate = value;
                    RaisePropertyChanged(nameof(MiniDate));
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
