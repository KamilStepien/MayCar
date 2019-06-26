using System;
using System.Collections.Generic;
using System.Text;
using MyCar.Model;

namespace MyCar.ViewModel
{
   public class CarsViewModel:BaseViewModel
   {
        private List<Vehicle> _vehicles;

        public List<Vehicle> Vehicles
        {
            get { return _vehicles; }
            set
            {
                if (_vehicles != value)
                {
                    _vehicles = value;
                    RaisePropertyChanged(nameof(Vehicles));
                }
            }
        }


    }
}
