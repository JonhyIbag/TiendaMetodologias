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
using Practica1.Controller;
using Practica1.View.Departamentos;

namespace Practica1.View
{
    /// <summary>
    /// Lógica de interacción para MenuDepartamentos.xaml
    /// </summary>
    public partial class MenuDepartamentos : Window
    {
        private CtrDepartamento controlador;
        public MenuDepartamentos()
        {
            this.controlador = new CtrDepartamento(); 
            InitializeComponent();
        }

        private void BtnAlta(object sender, RoutedEventArgs e)
        {
            FrameBotones.Navigate(new AltaDepto());
        }
        private void BtnConsultar(object sender, RoutedEventArgs e)
        {
            ArrayList departamentos = this.controlador.consultarDeptos();
            FrameBotones.Navigate(new ConsultarProducto(departamentos));
        }
        private void BtnBaja(object sender, RoutedEventArgs e)
        {
            FrameBotones.Navigate(new BajaDepto());
        }

        private void BtnSalir(object sender, RoutedEventArgs e)
        {
            MainWindow menuPrincipal = new MainWindow();
            this.Close();
            menuPrincipal.Show();
        }
    }
}
