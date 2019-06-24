using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyCar.Data;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyCar
{
    public partial class App : Application
    {
        private static LocalDatabase localDB;
        public static LocalDatabase LocalDB
        {
            get
            {
                if (localDB == null)
                {
                    var fileHelper = DependencyService.Get<IFileHelper>();
                    var path = fileHelper.GetLocalFilepath("app.database");
                    localDB = new Data.LocalDatabase(path);
                }

                return localDB;
            }
        }



        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new History());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
