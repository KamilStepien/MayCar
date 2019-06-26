using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartPage : ContentPage
	{
		public StartPage ()
		{

			InitializeComponent ();
		}
        public  void exit(object sender, EventArgs e)
        {

        }

        public async void contnue(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new History());
        }

        private async void start(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new CreateEditCar());
        }
    }
}