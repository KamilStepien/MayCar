﻿using System;
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

                
                StackLayout stackLayout = new StackLayout();
                for (int i = history.Count - 1; i >= lastLenghtTabHistory; i--)
                {
                    Grid grid;
                    switch (history[i].Typ)
                    {
                        case "petrol":
                            grid = new Grid { Margin = new Thickness(10, 10) ,  BackgroundColor = Color.FromHex("#d8f3d9") };
                            var TmpPetrol = await App.LocalDB.GetPetrolById(history[i].IdClass);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center , BackgroundColor = Color.FromHex("#5BCD60") ,  Text = "Bezyna"  },0,3,0,1);

                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Typ: " + TmpPetrol.TypeOfPetrol  } ,0,1);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Cena: " + TmpPetrol.Price.ToString() + " zł" },1,1);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Cena: " + TmpPetrol.PricePerLiter.ToString() + " zł/l" },2,1);
                            grid.Children.Add(new Label { Margin = new Thickness(0, 5, 0, 0), HorizontalTextAlignment = TextAlignment.Center, BackgroundColor = Color.FromHex("#5BCD60"), Text = TmpPetrol.DateOfCreation.ToString("dddd, dd MMMM yyyy") }, 0, 3, 2, 3);

                            stackLayout.Children.Add(grid);
                            break;

                        case "trip":
                            grid = new Grid { Margin = new Thickness(10,10)  ,BackgroundColor = Color.FromHex("#ffd7cc") };
                            var TmpTrip = await App.LocalDB.GetTripById(history[i].IdClass);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, BackgroundColor = Color.FromHex("#FF734D"), Text = "Wycieczka" }, 0, 3, 0, 1);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Nazwa: " + TmpTrip.Nazwa }, 0, 1);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Start: " + TmpTrip.StartPoint  }, 1, 1);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Cel : " + TmpTrip.Destination  }, 2, 1);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Odległość : " + TmpTrip.NumberOfKm + " km" }, 0, 2);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Start o "  + TmpTrip.Start}, 1, 3 , 2,3);
           
                            grid.Children.Add(new Label { Margin = new Thickness(0, 5, 0, 0), HorizontalTextAlignment = TextAlignment.Center, BackgroundColor = Color.FromHex("#FF734D"), Text = TmpTrip.Date.ToString("dddd, dd MMMM yyyy") }, 0, 3, 3, 4);

                            stackLayout.Children.Add(grid);
                            break;

                        case "drive":
                            grid = new Grid { Margin = new Thickness(10, 10), BackgroundColor = Color.FromHex("#ffe0cc") };
                            var tmpDrive = await App.LocalDB.GetDriveById(history[i].IdClass);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, BackgroundColor = Color.FromHex("#FF7211"), Text = "Drive" }, 0, 3, 0, 1);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Nazwa: " + tmpDrive.Nazwa }, 0, 1);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Miejsce startowe: " + tmpDrive.StartPoint }, 1, 1);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Odległość : " + tmpDrive.NumberOfKm + " km" }, 2, 1);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Rozpoczecie przejazdu : " + tmpDrive.StartTime.ToString() }, 0, 3, 2, 3);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Koniec przejazdu :" + tmpDrive.EndTime.ToString() }, 0, 3, 3, 4);
                            grid.Children.Add(new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Czas przejzdu : "  + tmpDrive.timeSpan.ToString() }, 0, 3, 4, 5);
                            grid.Children.Add(new Label { Margin = new Thickness(0, 5, 0, 0) ,  HorizontalTextAlignment = TextAlignment.Center, BackgroundColor = Color.FromHex("#FF7211"), Text = tmpDrive.Date.ToString("dddd, dd MMMM yyyy") }, 0, 3, 5, 6);


                            stackLayout.Children.Add(grid);
                            break;
                    }

                    lvPetrol.Children.Add(stackLayout);

                }
                lastLenghtTabHistory = history.Count;
            }
             
            
        }



       

    }
}