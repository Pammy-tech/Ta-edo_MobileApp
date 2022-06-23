using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TanedoMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Login(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login_Page(), true);
        }

        private async void Button_SignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register_Page(), true);
        }

    }
}
