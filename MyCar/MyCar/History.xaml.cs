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
        private int lastLenghtTabHistory = 0;
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

        private async void EnterCreateTrip(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateTripPage());
        }

        private async void EnterCreateDrive(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateDrive());
        }

        protected override async void OnAppearing()
        {
            var history = await App.LocalDB.GetHistory();

            if (lastLenghtTabHistory< history.Count)
            {

                
                Label label = new Label();
                for (int i = history.Count - 1; i >= lastLenghtTabHistory; i--)
                {
                    switch (history[i].Typ)
                    {
                        case "petrol":
                            var TmpPetrol = await App.LocalDB.GetPetrolById(history[i].IdClass);
                            label = new Label { Text = TmpPetrol.TypeOfPetrol.ToString(), TextColor = Color.FromHex("#77d065"), FontSize = 20 };

                            break;

                        case "trip":
                            var TmpTrip = await App.LocalDB.GetTripById(history[i].IdClass);
                            label = new Label { Text = TmpTrip.StartPoint, TextColor = Color.FromHex("#773265"), FontSize = 20 };

                            break;
                    }

                    lvPetrol.Children.Add(label);

                }
                lastLenghtTabHistory = history.Count;
            }
             
            
        }



       

    }
}