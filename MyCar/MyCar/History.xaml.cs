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
            fillData();
        }

        private void Add(object sender, EventArgs e)
        {
            _viewModel.DisplayMenu = !_viewModel.DisplayMenu;
        }

        private  async void EnterFillUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FillUpPage());
        }

        private async void EnterCreateTrip(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateTripPage());
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

        

        protected async void  fillData ()
        {
            var history = await App.LocalDB.GetHistory();
            Label label = new Label();
            for (int i = history.Count-1; i >=0; i-- )
            {
                switch(history[i].Typ)
                {
                    case "petrol":
                        var TmpPetrol = await App.LocalDB.GetPetrolById(history[i].Id);
                         label = new Label { Text = TmpPetrol.TypeOfPetrol.ToString(), TextColor = Color.FromHex("#77d065"), FontSize = 20 };
                       
                        break;

                    case "trip":
                        var TmpTrip = await App.LocalDB.GetPetrolById(history[i].Id);
                        label = new Label { Text = TmpTrip.TypeOfPetrol.ToString(), TextColor = Color.FromHex("#77d065"), FontSize = 20 };

                        break;
                }
               
                lvPetrol.Children.Add(label);
              
            }
            


           
        }


    }
}