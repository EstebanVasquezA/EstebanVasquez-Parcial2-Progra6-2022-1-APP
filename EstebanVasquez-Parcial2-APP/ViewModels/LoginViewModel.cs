using EstebanVasquez_Parcial2_APP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EstebanVasquez_Parcial2_APP.Models;
using System.Threading.Tasks;

namespace EstebanVasquez_Parcial2_APP.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Activo MiActivo { get; set; }

        public LoginViewModel()
        {
            MiActivo = new Activo();
        }

        public async Task<bool> AgregarActivo(string pNombre, string pArea, decimal pCosto)
        {
            if (IsBusy) return false;

            IsBusy = true;

            try
            {
                MiActivo.nombre = pNombre;
                MiActivo.area = pArea;
                MiActivo.costo = pCosto;

                bool R = await MiActivo.AgregarActivo();

                return R;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
