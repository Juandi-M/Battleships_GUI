using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin_Battleships
{
    public partial class App : Application
    {
         
        public static bool IsUserLoggedIn { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new Pages.MainMenu_Page();

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new Pages.LogIn_Page());
            }
            else
            {
                MainPage = new NavigationPage(new Xamarin_Battleships.Pages.MainMenu_Page());
            }
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
