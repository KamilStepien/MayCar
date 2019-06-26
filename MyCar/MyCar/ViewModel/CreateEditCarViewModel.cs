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
        private string _imgSource;

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
