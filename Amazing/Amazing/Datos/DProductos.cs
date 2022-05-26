using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Amazing.Modelo;


namespace Amazing.Datos
{
    public class DProductos
    {
        public ObservableCollection<MProductos> ListarProductos()
        {
            return new ObservableCollection<MProductos>()
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
                    Precio= "C$ 670",
                    Imagen= "https://i.ibb.co/pb9HLzc/Whats-App-Image-2022-05-21-at-10-56-11-AM-modified.png"
                },
                  new MProductos()
                {
                    Nombre= "Pantalones Jeans",
                    Descripcion= "Todos los colores disponibles",
                    Precio= "C$ 670",
                    Imagen= "https://i.ibb.co/0cpFpv4/IMG01.png"
                },
                   new MProductos()
                {
                    Nombre= "Pantalones Jeans",
                    Descripcion= "Todos los colores disponibles",
                    Precio= "C$ 670",
                    Imagen= "https://i.ibb.co/0cpFpv4/IMG01.png"
                },
                    new MProductos()
                {
                    Nombre= "Pantalones Jeans",
                    Descripcion= "Todos los colores disponibles",
                    Precio= "C$ 670",
                    Imagen= "https://i.ibb.co/0cpFpv4/IMG01.png"
                }
            };
        }
    }
}
