using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazing.Vistas.CRUD;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amazing.Vistas.Detalle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cuerpo : ContentView
    {
        public Cuerpo()
        {
            InitializeComponent();
        }

        private void btnEditar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EditarProductos());
        }

        private void TapMas_Tapped(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(lblCantidad.Text);
            cantidad += 1;
            lblCantidad.Text = cantidad.ToString();
        }

        private void TapMenos_Tapped(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(lblCantidad.Text);
            if (cantidad > 1)
            {
                cantidad -= 1;
            }
            lblCantidad.Text = cantidad.ToString();
        }
    }
}