using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Battleships.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu_Page : ContentPage
    {
        public MainMenu_Page()
        {
            InitializeComponent();

        }

        private void Button_Clicked_Start(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_LogIN(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_Credits(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Credits());
        }

        private void Button_Clicked_Options(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Options());
        }

    }
}