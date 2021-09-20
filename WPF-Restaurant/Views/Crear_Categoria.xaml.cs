using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_Restaurant.Model;

namespace WPF_Restaurant.Views
{
    /// <summary>
    /// Interaction logic for Crear_Categoria.xaml
    /// </summary>
    public partial class Crear_Categoria : Window
    {
        public Crear_Categoria()
        {
            InitializeComponent();
        }

        public void SP_Crear_Categoria(object sender, RoutedEventArgs e )
        {
            List<Categorias> lstcat = new List<Categorias>();
            DbConnection dbcon = new DbConnection();
            string nombre = this.txtName.Text;
            string descripcion = this.txtDesc.Text;

            Categorias cat = new Categorias();
            {
                cat.Nombre_Categoria = nombre;
                cat.Descripcion_Categoria = descripcion;
            }
            dbcon.Crear_Categoria(cat);
            
            
        }
    }
}
