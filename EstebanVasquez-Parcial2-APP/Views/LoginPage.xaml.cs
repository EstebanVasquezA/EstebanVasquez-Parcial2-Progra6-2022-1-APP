using EstebanVasquez_Parcial2_APP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EstebanVasquez_Parcial2_APP.ViewModels;

namespace EstebanVasquez_Parcial2_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel viewModel;
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new LoginViewModel();
        }

        private async void CmdAgregarActivo(object sender, EventArgs e)
        {
            bool R = await viewModel.AgregarActivo(TxtNombreActivo.Text.Trim(), TxtArea.Text.Trim(), 
                                                   Convert.ToDecimal(TxtCosto.Text.Trim()));

            if (R)
            {
                await DisplayAlert("Info", "El Activo ha sido agregado correctamente al sistema", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Error", "Se produjo un error al agregar el Activo", "OK");
            }
        }
    }
}