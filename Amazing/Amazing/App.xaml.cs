using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Amazing.Vistas.MenuPrincipal;

namespace Amazing
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Principal();
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
