using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstebanVasquez_Parcial2_APP.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void CmdCrearActivos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}