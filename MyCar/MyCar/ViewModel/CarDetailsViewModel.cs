using System;
using System.Collections.Generic;
using System.Text;
using MyCar.Model;

namespace MyCar.ViewModel
{
    class CarDetailsViewModel:BaseViewModel
    {
        private Vehicle _vehicle;

        public Vehicle Car
        {
            get { return _vehicle; }
            set
            {
                if (_vehicle != value)
                {
                    _vehicle = value;
                    RaisePropertyChanged(nameof(Car));
                }
            }
        }



    }
}
