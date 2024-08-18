using Practica1.View.Asignaciones;
using Practica1.View.Precios;
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
using System.Windows.Shapes;

namespace Practica1.View
{
    /// <summary>
    /// Lógica de interacción para MenuPrecios.xaml
    /// </summary>
    public partial class MenuPrecios : Window
    {
        public MenuPrecios()
        {
            InitializeComponent();
        }
        private void BtnAsignarPrecio(object sender, RoutedEventArgs e)
        {
            FrameBotones.Navigate(new AsignarPrecio());
        }
        private void BtnConsultar(object sender, RoutedEventArgs e)
        {
            FrameBotones.Navigate(new ConsultarPrecios());
        }

        private void BtnSalir(object sender, RoutedEventArgs e)
        {
            MainWindow menuPrincipal = new MainWindow();
            this.Close();
            menuPrincipal.Show();
        }
    }
}
