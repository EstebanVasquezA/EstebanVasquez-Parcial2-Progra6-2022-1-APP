using EstebanVasquez_Parcial2_APP.Services;
using EstebanVasquez_Parcial2_APP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstebanVasquez_Parcial2_APP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new AboutPage());
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
