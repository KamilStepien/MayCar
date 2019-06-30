using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyCar.Data;
using System.Threading;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyCar
{
    public partial class App : Application
    {
        private static Stopwatch stopWatch;
        private static LocalDatabase localDB;

        public static Stopwatch StopWatch
        {
            get
            {
                if(stopWatch is null)
                {
                    stopWatch = new Stopwatch();
                }
                return stopWatch;
            }
        }


        public static LocalDatabase LocalDB
        {
            get
            {
                if (localDB == null)
                {
                    var fileHelper = DependencyService.Get<IFileHelper>();
                    var path = fileHelper.GetLocalFilepath("app.dbe");
                    localDB = new Data.LocalDatabase(path);
                    
                }

                return localDB;
            }
        }



        public  App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CreateEditCar());
        }
  
      
        protected async override void OnStart()
        {

           

         
        
             
             
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
