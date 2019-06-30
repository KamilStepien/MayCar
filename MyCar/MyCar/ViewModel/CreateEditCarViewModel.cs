using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCar.ViewModel
{
    class CreateEditCarViewModel:BaseViewModel
    {
        private string  _carName;
        private string _carModel;
        private string _carMark;
        private int _fuelTank;
        private double _lonHundredtKm;
        private DateTime _endCarInsurance;
        private DateTime _currentDateTime;
        private DateTime _endCarReview;
        private DateTime _dateOfCreation;
        private string _imgSource;
        private bool _isEddit;

        private string _errorMessage = "Nie uzupełniono wszystkich pól";
        private bool _errorMessageIsVisible = false;

        public string ErrorMessage => _errorMessage;


        public bool IsEddit
        {
            get
            {
                return _isEddit;
            }
            set
            {
                if (_isEddit != value)
                {
                    _isEddit = value;
                    RaisePropertyChanged(nameof(IsEddit));
                }
            }
        }

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



        public DateTime CurrentDateTime
        {
            get { return _currentDateTime; }
            set
            {
                if (_currentDateTime != value)
                {
                    _currentDateTime = value;
                    RaisePropertyChanged(nameof(CurrentDateTime));
                }
            }
        }

        public DateTime EndCarReview
        {
            get { return _endCarReview; }
            set
            {
                if (_endCarReview != value)
                {
                    _endCarReview = value;
                    RaisePropertyChanged(nameof(EndCarReview));
                }
            }
        }

        public DateTime DateOfCreation
        {
            get { return _dateOfCreation; }
            set
            {
                if (_dateOfCreation != value)
                {
                    _dateOfCreation = value;
                    RaisePropertyChanged(nameof(DateOfCreation));
                }
            }
        }

        public DateTime EndCarInsurance
        {
            get { return _endCarInsurance; }
            set
            {
                if (_endCarInsurance != value)
                {
                    _endCarInsurance = value;
                    RaisePropertyChanged(nameof(EndCarInsurance));
                }
            }
        }

        public double LonHundredtKm
        {
            get { return _lonHundredtKm; }
            set
            {
                if (_lonHundredtKm != value)
                {
                    _lonHundredtKm = value;
                    RaisePropertyChanged(nameof(LonHundredtKm));
                }
            }
        }

        public int FuelTank
        {
            get { return _fuelTank; }
            set
            {
                if (_fuelTank != value)
                {
                    _fuelTank = value;
                    RaisePropertyChanged(nameof(FuelTank));
                }
            }
        }

        public string CarMark
        {
            get { return _carMark; }
            set
            {
                if (_carMark != value)
                {
                    _carMark = value;
                    RaisePropertyChanged(nameof(CarMark));
                }
            }
        }

        public string ImageSource
        {
            get { return _imgSource; }
            set
            {
                if (_imgSource != value)
                {
                    _imgSource = value;
                    RaisePropertyChanged(nameof(ImageSource));
                }
            }
        }

        public string CarName
        {
            get { return _carName; }
            set
            {
                if (_carName != value)
                {
                    _carName = value;
                    RaisePropertyChanged(nameof(CarName));
                }
            }
        }

        public string CarModel
        {
            get { return _carModel; }
            set
            {
                if (_carModel != value)
                {
                    _carModel = value;
                    RaisePropertyChanged(nameof(CarModel));
                }
            }
        }
    }
}
