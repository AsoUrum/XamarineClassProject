using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace finalProject
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;

        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());
           // MainPage = new IngredientsSearchPage();
            //MainPage = new NavigationPage(new IngredientsSearchPage());
            //MainPage = new SignUpPage();
           MainPage = new NavigationPage(new LogInPage());
        }

        public App(string databaseLocation)
        {
            InitializeComponent();
            // MainPage = new SignUpPage();
            MainPage =  new NavigationPage(new LogInPage());

            //MainPage = new NavigationPage(new MainPage());
            DatabaseLocation = databaseLocation;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
