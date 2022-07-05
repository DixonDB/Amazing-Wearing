using Amazing.Modelo;
using Amazing.RepoDB;
using Amazing.Vistas.MenuPrincipal;
using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amazing.Vistas.Inicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }


        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            if(txtPassword.Text.Trim().Equals("") || txtEmail.Text.Trim().Equals(""))
            {
                await DisplayAlert("Error", "Ingresa los datos correctamente", "Aceptar");
                return;
            }

            UserAuthentication oUsuario = new UserAuthentication()
            {
                email = txtEmail.Text,
                password = txtPassword.Text,
                returnSecureToken = true
            };

            bool respuesta = await ApiServiceAuthentication.Login(oUsuario);
            if (respuesta)
            {
                Application.Current.MainPage = new SharedTransitionNavigationPage(new Principal());
            }
            else
            {
                await DisplayAlert("Oops", "Usuario no encontrado", "OK");
                txtEmail.Text = "";
                txtPassword.Text = "";
            }

           
        }

        private void Registro_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Registro());
        }
    }
}