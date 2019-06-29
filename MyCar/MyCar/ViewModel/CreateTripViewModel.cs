using System;
using System.Collections.Generic;
using System.Text;
using MyCar.Model;

namespace MyCar.ViewModel
{
    class CreateTripViewModel:BaseViewModel
    {
        private string  _tripName = "";
        private int  _tripNumberOfKm = 0;
        private string _tripDestination = "";
        private string _tripStartPoint ="";

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

        public string TripDestination
        {
            get { return _tripDestination; }
            set
            {
                if (_tripDestination != value)
                {
                    _tripDestination = value;
                    RaisePropertyChanged(nameof(TripDestination));
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
