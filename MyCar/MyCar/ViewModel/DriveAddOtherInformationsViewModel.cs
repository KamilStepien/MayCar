using System;
using System.Collections.Generic;
using System.Text;
using MyCar.Model;

namespace MyCar.ViewModel
{
    class DriveAddOtherInformationsViewModel:BaseViewModel
    {
        private string _tripName ;
        private int _tripNumberOfKm ;
     
        private string _tripStartPoint ;


        private string _errorMessage = "Nie uzupełniono wszystkich pól";
        private bool _errorMessageIsVisible = false;

        public string ErrorMessage => _errorMessage;


        public bool ErrorMessageIsVisible
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
                    RaisePropertyChanged(nameof(ErrorMessageIsVisible));
                }
            }
        }

        public string TripName
        {
            get { return _tripName; }
            set
            {
                if (_tripName != value)
                {
                    _tripName = value;
                    RaisePropertyChanged(nameof(TripName));
                }
            }
        }

       

        public string TripStartPoint
        {
            get { return _tripStartPoint; }
            set
            {
                if (_tripStartPoint != value)
                {
                    _tripStartPoint = value;
                    RaisePropertyChanged(nameof(TripStartPoint));
                }
            }
        }

        public int TripNumberOfKm
        {
            get { return _tripNumberOfKm; }
            set
            {
                if (_tripNumberOfKm != value)
                {
                    _tripNumberOfKm = value;
                    RaisePropertyChanged(nameof(TripNumberOfKm));
                }
            }
        }
    }
}
