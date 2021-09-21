using System;
using System.Collections.Generic;
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
    /// Interaction logic for Eliminar_Categoria.xaml
    /// </summary>
    public partial class Eliminar_Categoria : Window
    {
        DbConnection conn = new DbConnection();
        public Eliminar_Categoria()
        {
            InitializeComponent();
            
            dgcat.ItemsSource = conn.GetCategorias();
            
            
            
        }
        public async void SP_Eliminar_Categoria(object sender , RoutedEventArgs e,int? id)
        {
            
            var temp = this.dgcat.SelectedItem;
            

        }
    }
}
