using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.ViewModel
{
    class StatisticViewModel:BaseViewModel
    {
        private int _vehicle;
        private double _allNumberOFKm;
        private double _allLitrPetrol;
        private string _allRidesHour;

        public int Vehicle
        {
            get { return _vehicle; }
            set
            {
                if (_vehicle != value)
                {
                    _vehicle = value;
                    RaisePropertyChanged(nameof(Vehicle));
                }
            }
        }

        public double AllNumberOFKm
        {
            get { return _allNumberOFKm; }
            set
            {
                if (_allNumberOFKm != value)
                {
                    _allNumberOFKm = value;
                    RaisePropertyChanged(nameof(AllNumberOFKm));
                }
            }
        }
        public double AllLitrPetrol
        {
            get { return _allLitrPetrol; }
            set
            {
                if (_allLitrPetrol != value)
                {
                    _allLitrPetrol = value;
                    RaisePropertyChanged(nameof(AllLitrPetrol));
                }
            }
        }
        public string AllRidesHour
        {
            get { return _allRidesHour; }
            set
            {
                if (_allRidesHour != value)
                {
                    _allRidesHour = value;
                    RaisePropertyChanged(nameof(AllRidesHour));
                }
            }
        }

    }
    
}
