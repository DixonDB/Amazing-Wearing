using Amazing.Modelo;
using Amazing.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amazing.Vistas.Detalle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleProducto : ContentPage
    {
        public DetalleProducto(MProductos parametros) 
        {
            InitializeComponent();
            BindingContext = new VMDetalle(Navigation, parametros);
        }
    }
}