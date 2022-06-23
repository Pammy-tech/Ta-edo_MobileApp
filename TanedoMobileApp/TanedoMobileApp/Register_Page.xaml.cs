using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TanedoMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register_Page : ContentPage
    {
        public Register_Page()
        {
            InitializeComponent();
        }

        private async void Button_SignUp(object sender, EventArgs e)
        {
            var ans = await DisplayAlert("Registered!", "Proceed to Login?", "Yes", "No");
            if (ans ==  true)
            {
                await Navigation.PushAsync(new Login_Page(), true);
            }
            else
            {
                //stay home
            }
        }
    }
}