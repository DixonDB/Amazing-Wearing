using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazing.Modelo;
using Amazing.RepoDB;
using Amazing.Vistas.MenuPrincipal;
using Plugin.SharedTransitions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amazing.Vistas.Inicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            InitializeComponent();
            obtenerUsuario();
        }
        Usuario oGlobalUsuario;

        private async void btnGuardarCambios_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCelular.Text.Trim() == "")
            {
                await DisplayAlert("Mensaje", "Debe completar todos los campos", "OK");
                return;
            }


            Usuario oUsuario = new Usuario()
            {
                Nombres = txtNombre.Text,
                Apellidos = txtApellido.Text,
                Celular = Convert.ToInt32(txtCelular.Text),
                Clave = oGlobalUsuario.Clave,
                Email = oGlobalUsuario.Email
            };
            
            bool respuesta = await ApiServiceFirebase.GuardarCambiosUsuario(oUsuario);

            if (respuesta)
            {
                await DisplayAlert("Mensaje", "Se guardaron los cambios", "OK");
                Navigation.PushAsync(new SharedTransitionNavigationPage(new Principal()));
            }
            else
            {
                await DisplayAlert("Mensaje", "Hubo un error al guardar", "OK");
            }
        }
        private async void obtenerUsuario()
        {

            oGlobalUsuario = await ApiServiceFirebase.ObtenerUsuario();

            if (oGlobalUsuario != null)
            {
                txtNombre.Text = oGlobalUsuario.Nombres;
                txtApellido.Text = oGlobalUsuario.Apellidos;
                txtCelular.Text =oGlobalUsuario.Celular.ToString();
                txtEmail.Text = oGlobalUsuario.Email;

            }
        }

        private void btnCerrarSesion_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Login();
        }
    }
}