using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Amazing.VistaModelo;
using Amazing.Modelo;
using Amazing.RepoDB;
using Amazing.Datos;
using Plugin.SharedTransitions;
using Amazing.Vistas.MenuPrincipal;

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
        public async Task EliminarPublicacion(MProductos parametros)
        {
            bool quiresEliminar = await DisplayAlert("Eliminar publicacion", $"¿Quieres eliminar la publicacion {parametros.Nombre}?", "Si", "No");

            if (quiresEliminar)
            {
                var firebase = new RepoProductosFirebase();

                string id = parametros.IdProducto;

                bool resultado = await firebase.EliminarProducto(id);

                if (resultado)
                {
                    await DisplayAlert("Exito", $"El producto {parametros.Nombre} a sido eliminada", "ok");
                    Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", $"Intente eliminar la publicacion {parametros.Nombre} mas tarde", "ok");
                }
            }
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
        public Command EliminarProductocommand { get; }
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
