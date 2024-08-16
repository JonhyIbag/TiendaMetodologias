using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Practica1.View;

namespace Practica1
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

        private void BtnProductos(object sender, RoutedEventArgs e)
        {
            MenuProductos menuProductos = new MenuProductos();
            menuProductos.Show();
            this.Close();
        }
        private void BtnDepartamentos(object sender, RoutedEventArgs e)
        {
            MenuDepartamentos menuDepartamentos = new MenuDepartamentos();
            this.Close();
            menuDepartamentos.Show();
        }

        private void BtnAsignaciones(object sender, RoutedEventArgs e)
        {
            MenuAsignaciones menuAsignaciones = new MenuAsignaciones();
            this.Close();
            menuAsignaciones.Show();
        }

        private void BtnPrecios(object sender, RoutedEventArgs e)
        {
            MenuPrecios menuPrecios = new MenuPrecios();
            this.Close();
            menuPrecios.Show();
        }

        private void BtnSalir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}