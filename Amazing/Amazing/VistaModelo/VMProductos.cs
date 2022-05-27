using System;
using System.Collections.Generic;
using System.Text;
using Amazing.Modelo;
using Amazing.RepoDB;
using System.Collections.ObjectModel;

namespace Amazing.VistaModelo
{
    public class VMProductos: VMBase
    {
        RepoProductosFirebase repoFB = new RepoProductosFirebase();
        public VMProductos()
        {

        }
        private ObservableCollection<MProductos> Productos;
        public ObservableCollection<MProductos> productos 
        { 
            get { return Productos; }
            set {
                this.Productos = value;
                OnPropertyChanged("Productos");
                 }
        }    
    }
}
