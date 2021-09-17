using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Restaurant.Model
{
    class Pedidos
    {
        public int id { get; set; }
        public int id_pedido { get; set; }
        public int id_restaurante { get; set; }
        public int id_menu { get; set; }
        public int Cantidad { get; set; }
        public int id_usuario { get; set; }
        public int id_mesa { get; set; }
        public bool Entrega_Domicilio { get; set; }
        public int id_entrega_domicilio { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
    }
}
