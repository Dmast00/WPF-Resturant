using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Restaurant.Model
{
    class Menus
    {
        public int id { get; set; }
        public string Nombre_Menu { get; set; }
        public string Descripcion_Menu { get; set; }
        public decimal Precio { get; set; }
        public int id_categoria { get; set; }
        public byte[] Imagen { get; set; }
    }
}
