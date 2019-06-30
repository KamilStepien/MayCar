using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.ViewModel
{
    class CreateDriveViewModel:BaseViewModel
    {
        private TimeSpan _time;



       


        public TimeSpan Time
        {
            get { return _time; }
            set
            {
                if (_time != value)
                {
                    _time = value;
                    RaisePropertyChanged(nameof(Time));
                }
            }
        }
    }
}
