using System;
using System.Collections;
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
using Microsoft.VisualBasic;
using Practica1.Controller;

namespace Practica1.View
{
    /// <summary>
    /// Lógica de interacción para MenuProductos.xaml
    /// </summary>
    public partial class MenuProductos : Window
    {
        private CtrProducto controlador;
        
        public MenuProductos()
        {
            this.controlador = new CtrProducto();
            InitializeComponent();
        }

        private void BtnAlta(object sender, RoutedEventArgs e)
        {
            FrameBotones.Navigate(new AltaProducto());
        }

        private void BtnConsultar(object sender, RoutedEventArgs e)
        {
            ArrayList productos = this.controlador.consultarProductos();
            FrameBotones.Navigate(new ConsultarProducto(productos));
        }
        private void BtnBaja(object sender, RoutedEventArgs e)
        {
            FrameBotones.Navigate(new BajaProducto());
        }
        private void BtnSalir(object sender, RoutedEventArgs e)
        {
            MainWindow menuPrincipal = new MainWindow();
            this.Close();
            menuPrincipal.Show();
        }
    }
}
