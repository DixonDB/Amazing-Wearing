using Amazing.Vistas.MenuPrincipal;
using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amazing.Vistas.CRUD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarProductos : ContentPage
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }


        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SharedTransitionNavigationPage(new Principal()));
        }
    }
}