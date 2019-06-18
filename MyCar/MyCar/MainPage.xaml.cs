using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyCar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

         private async void PetrolCalculator_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PetrolCalculator());
        }
    }
}
