using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazing.VistaModelo;
using Amazing.RepoDB;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amazing.Vistas.MenuPrincipal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        RepoProductosFirebase con = new RepoProductosFirebase();
        public Principal()
        {
            InitializeComponent();
            BindingContext = new VMPrincipal(Navigation);
        }
       
    }
}