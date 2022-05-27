using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Amazing.VistaModelo;
using Amazing.Modelo;

namespace Amazing.VistaModelo
{
    public class VMDetalle : VMBase
    {
        #region VARIABLES
        string _Texto;
        public MProductos ParametrosRecibe { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMDetalle(INavigation navigation, MProductos parametrostrae)
        {
            Navigation = navigation;
            ParametrosRecibe = parametrostrae;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        private async void Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(Volver);
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
