using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyCar.ViewModel;
using MyCar.Model;

namespace MyCar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class History : ContentPage
	{
        private HistoryViewModel _viewModel = new HistoryViewModel();

        public  History ()
		{
            InitializeComponent ();
            BindingContext = _viewModel;
        }

        private void Add(object sender, EventArgs e)
        {
            _viewModel.DisplayMenu = !_viewModel.DisplayMenu;
        }

        private  async void EnterFillUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FillUpPage());
        }

        private async void NaviToHistory(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new History());
        }

        private async void NaviToCars(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cars());
        }

        private  void NaviToPetrol(object sender, EventArgs e)
        {
           
        }

        private  void NaviToTrip(object sender, EventArgs e)
        {
            
        }

        protected override async void OnAppearing()
        {
            var students = await App.LocalDB.GetPetrol();
   

            lvPetrol.ItemsSource = students;
      
        }


    }
}