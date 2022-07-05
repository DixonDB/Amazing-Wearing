using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Amazing.Modelo;
using System.Threading.Tasks;
using Amazing.RepoDB;
using Firebase.Database;

namespace Amazing.Datos
{
    public class DProductos
    {
        #region Insertar
        /*  public async Task InsertarProductos(MProductos parametros)
          {
              await RepoProductosFirebase.con
                  .Child("Productos")
                  .PostAsync(new MProductos()
                  {
                      Colorfondo = parametros.Colorfondo,
                      Colorpoder = parametros.Colorpoder,
                      Icono = parametros.Icono,
                      Nombre = parametros.Nombre,
                      Nroorden = parametros.Nroorden,
                      Poder = parametros.Poder
                  }
                  );
          }*/
        #endregion
        public async Task <ObservableCollection<MProductos>> ListarProductos()
        {
            var data = await Task.Run(() => RepoProductosFirebase.con
               .Child("Productos")
               .AsObservable<MProductos>()
               .AsObservableCollection()
               );
            return data;
            #region Estaticos
            /*  return new ObservableCollection<MProductos>()
              {
                  new MProductos()
                  {
                      Nombre= "Pantalones Jeans",
                      Descripcion= "Todos los colores disponibles",
                      Precio= "C$ 670",
                      Imagen= "https://i.ibb.co/SXBm90m/P1-modified.png"
                  },
                   new MProductos()
                  {
                      Nombre= "Zapatos Converse",
                      Descripcion= "Tallas 8,9,6",
                      Precio= "C$ 1575",
                      Imagen= "https://ibb.co/8BdNLLx"
                  },
                    new MProductos()
                  {
                      Nombre= "Pantalones Jeans",
                      Descripcion= "Todos los colores disponibles",
                      Precio= "C$ 670",
                      Imagen= "https://ibb.co/34LxCN2"
                  },
                     new MProductos()
                  {
                      Nombre= "Pantalones Jeans",
                      Descripcion= "Todos los colores disponibles",
                      Precio= "C$ 670",
                      Imagen= "https://pin.it/sFrS55C"
                  },
                      new MProductos()
                  {
                      Nombre= "Pantalones Jeans",
                      Descripcion= "Todos los colores disponibles",
                      Precio= "C$ 670",
                      Imagen= "https://i.ibb.co/0cpFpv4/IMG01.png"
                  }
              };*/
            #endregion
        }
    }
}
