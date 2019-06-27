using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCar.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateTripPage : ContentPage
	{
        private CreateTripViewModel _view = new CreateTripViewModel();
		public CreateTripPage ()
		{
            
			InitializeComponent ();
            BindingContext = _view;
            _view.Seconds = 100;

        }

	}
}