using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.ViewModel
{
    class CreateTripViewModel:BaseViewModel
    {
        private int _seconds;

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (_seconds != value)
                {
                    _seconds = value;
                    RaisePropertyChanged(nameof(Seconds));
                }
            }
        }
    }
}
