using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Amazing.VistaModelo;

namespace Amazing.Modelo
{
    public class MCategorias : VMBase
    {
        [PrimaryKey, AutoIncrement]
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }

        //objetos
        string _color1; 
        string _color2;
        string _texcolor;
        bool _selectitem;
            
        public bool SelectItem
        {
            get { return _selectitem; }
            set { SetValue(ref _selectitem, value); }
        }
        public string Color1
        {
            get { return _color1; }
            set { SetValue(ref _color1, value); }
        }
        public string Color2
        {
            get { return _color2; }
            set { SetValue(ref _color2, value); }
        }
        public string TextColor
        {
            get { return _texcolor; }
            set { SetValue(ref _texcolor, value); }
        }
    }
}
