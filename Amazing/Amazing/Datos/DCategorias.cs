using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Amazing.Modelo;

namespace Amazing.Datos
{
    public class DCategorias
    {
        public ObservableCollection<MCategorias> MostrarCategorias()
        {
            return new ObservableCollection<MCategorias>()
            {
                new MCategorias()
                {
                    Categoria= "Jeans",
                    Imagen="https://i.ibb.co/MncgVrS/jeans.png",
                    TextColor="#2F394B",
                    Color1 ="#ffffff",
                    Color2="#ffffff",
                    SelectItem= false
                },
                new MCategorias()
                {
                    Categoria= "Camisetas",
                    Imagen="https://i.ibb.co/sWr22q7/camisetas.png",
                    TextColor="#2F394B",
                    Color1 ="#ffffff",
                    Color2="#ffffff",
                    SelectItem= false
                },
                new MCategorias()
                {
                    Categoria= "Zapatos",
                    Imagen="https://i.ibb.co/GTtFHcD/zapatos.png",
                    TextColor="#2F394B",
                    Color1 ="#ffffff",
                    Color2="#ffffff",
                    SelectItem= false
                }
            };
        }
    }
}
