using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar.ViewModel
{
    class HistoryViewModel:BaseViewModel
    {
        private bool _displayMenu = false;



        public bool DisplayMenu
        {
            get
            {
                return _displayMenu;
            }
            set
            {
                if (_displayMenu != value)
                {
                    _displayMenu = value;
                    RaisePropertyChanged(nameof(DisplayMenu));
                }
            }
        }



    }
}
