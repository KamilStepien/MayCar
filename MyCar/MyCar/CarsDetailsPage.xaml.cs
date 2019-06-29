using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCar.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyCar.Model;

namespace MyCar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarsDetailsPage : ContentPage
	{
        private CarDetailsViewModel _view = new CarDetailsViewModel();
		public CarsDetailsPage (Vehicle vehicle)
		{
            
            InitializeComponent ();
            BindingContext = _view;
            _view.Car = vehicle;
        }

       
    }
}