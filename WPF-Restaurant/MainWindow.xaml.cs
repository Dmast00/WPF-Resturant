using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Restaurant.Views;

namespace WPF_Restaurant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigationViewItem_MouseDown(object sender, RoutedEventArgs e)
        {
            Crear_Categoria ctg = new Crear_Categoria();
            ctg.ShowDialog();

        }

        private void mnu_eliminar_categoria(object sender ,RoutedEventArgs e)
        {
            Eliminar_Categoria elm = new Eliminar_Categoria();
            elm.ShowDialog();
        }

        private void NavigationViewItem_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
