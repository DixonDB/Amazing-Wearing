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
        RepoProductosFirebase repoFB;
        public VMProductos()
        {

        }
        private ObservableCollection<MProductos> mProductos;
        public ObservableCollection<MProductos> Productos 
        { 
            get { return mProductos; }
            set {
                this.mProductos = value;
                OnPropertyChanged("Productos");
                 }
        }    
    }
}
