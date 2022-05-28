using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace Amazing.Modelo
{
    public class MProductos
    {
        public MProductos()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        [PrimaryKey, AutoIncrement]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public string Imagen { get; set; }
    }
}
