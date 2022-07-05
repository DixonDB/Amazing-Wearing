using Amazing.Vistas.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.SharedTransitions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Amazing.Vistas.Inicio;

namespace Amazing.Vistas.MenuPrincipal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PiePagina : ContentView
    {
        public PiePagina()
        {
            InitializeComponent();
        }

        private void Agregar_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgregarProductos());
        }

        private void IrInicio_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Perfil_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Perfil());
        }
    }
}