using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Restaurant.Model
{
    class Usuarios
    {
        public int id { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Correo_Electronico { get; set; }
        public string Telefono_Usuario { get; set; }
        public string Contrasena_Usuario { get; set; }
        public int id_area { get; set; }
        public int id_perfil { get; set; }
    }
}
