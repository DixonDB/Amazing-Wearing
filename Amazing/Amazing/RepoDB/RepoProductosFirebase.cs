using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.ObjectModel;
using Amazing.Modelo;
using System.Threading.Tasks;
using System.Linq;

namespace Amazing.RepoDB
{
    public class RepoProductosFirebase
    {
       public static FirebaseClient con= new FirebaseClient("https://amazing-ce8f1-default-rtdb.firebaseio.com/");
        #region BREAD
        /*  public async Task<List<MProductos>> GetProductos()
          {
              return (await con
                  .Child("Productos")
                  .OnceAsync<MProductos>()).Select(item => new MProductos
                  {
                      IdProducto = item.Object.IdProducto,
                      Nombre = item.Object.Nombre,
                      Descripcion = item.Object.Descripcion,
                      Precio = item.Object.Precio,
                      Imagen = item.Object.Imagen
                  }).ToList();
          }
          public async Task<MProductos> BuscarProductos(int Id)
          {
              var productos = await GetProductos();
              await con
                  .Child("Productos")
                  .OnceAsync<MProductos>();
              return productos.Where(a => a.IdProducto == Id).FirstOrDefault();   
          }*/
        #endregion
        public async Task InsertarProductos(string nombre, string descripcion, string precio, string imagen)
        {
            await con
                .Child("Productos")
                .PostAsync(new MProductos()
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Precio = precio,
                    Imagen = imagen
                });
        }
       
        //public async Task ActualizarProductos(int id, string nombre, string descripcion, string precio, string imagen)
        //{
        //    //consulta para buscar 
        //    var query = (await con
        //        .Child("Productos")
        //        .OnceAsync<MProductos>()).Where(a => a.Object.IdProducto == id).FirstOrDefault();
        //    //Aqui las instrucciones de actualizacion
        //    await con
        //        .Child("Productos")
        //        .Child(query.Key)
        //        .PutAsync(new MProductos()
        //        {
        //            IdProducto = id,
        //            Nombre = nombre,
        //            Descripcion = descripcion,
        //            Precio = precio,
        //            Imagen = imagen
        //        });
        //}
        public async Task<bool> EliminarProducto(string id)
        {
            await con
                .Child("Productos")
                .Child(id)
                .DeleteAsync();

            return true;
        }
     
        

    }
}
