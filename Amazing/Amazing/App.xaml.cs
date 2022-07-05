using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Amazing.Vistas.MenuPrincipal;
using Amazing.Vistas.Inicio;
using Amazing.Vistas.CRUD;
using Amazing.Vistas.Detalle;
using Plugin.SharedTransitions;


namespace Amazing
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new Registro();
            MainPage = new Login();
            //MainPage = new AgregarProductos();
            //MainPage = new DetalleProducto();
            //MainPage = new NavigationPage(new Principal());
            //MainPage = new SharedTransitionNavigationPage(new Principal());
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
