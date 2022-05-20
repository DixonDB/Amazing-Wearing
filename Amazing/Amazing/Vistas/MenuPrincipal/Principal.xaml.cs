using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazing.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amazing.Vistas.MenuPrincipal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
            BindingContext = new VMPrincipal(Navigation);
        }
    }
}