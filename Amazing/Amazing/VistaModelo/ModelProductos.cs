using System;
using System.Collections.Generic;
using System.Text;
using Amazing.Modelo;
using Amazing.RepoDB;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Plugin.SharedTransitions;
using Amazing.Vistas.MenuPrincipal;

namespace Amazing.VistaModelo
{
    public class ModelProductos : VMBase
    {
        RepoProductosFirebase repoFB;
        public ModelProductos()
        {
            this.productos = new MProductos();
            this.repoFB = new RepoProductosFirebase();
        }
        private MProductos Producto;
        public MProductos productos
        {
            get { return this.Producto; }
            set
            {
                this.Producto = value;
                OnPropertyChanged("Productos");
            }
        }
        public Command InsertarProducto
        {
            get
            {
                return new Command(async () =>
                {
                    await repoFB.InsertarProductos(Producto.Nombre, Producto.Descripcion, Producto.Precio, Producto.Imagen);
                    await Application.Current.MainPage.DisplayAlert("OK", "Se insertaron los datos correctamente", "Aceptar");
                    
                });
            }
           
        }
      
        //public Command ActualizarProducto
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
        //            await this.repoFB.ActualizarProductos(this.Producto.IdProducto, this.Producto.Nombre,
        //                this.Producto.Descripcion, this.Producto.Precio, this.Producto.Imagen);
        //            await Application.Current.MainPage.DisplayAlert("OK","Se actualizaron correctamente los datos","Aceptar");
        //        });
        //    }
        //}
      
    }
}
