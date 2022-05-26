using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Amazing.Vistas.MenuPrincipal;
using Amazing.Vistas.CRUD;


namespace Amazing
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AgregarProductos();
            //MainPage = new NavigationPage(new Principal());
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
