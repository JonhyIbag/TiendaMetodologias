using Practica1.Controller;
using Practica1.View.Asignaciones;
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

namespace Practica1.View
{
    /// <summary>
    /// Lógica de interacción para MenuAsignaciones.xaml
    /// </summary>
    public partial class MenuAsignaciones : Window
    {
        private CtrAsignaciones controlador; 
        
        public MenuAsignaciones()
        {
            this.controlador = new CtrAsignaciones();
            InitializeComponent();
        }

        private void BtnAlta(object sender, RoutedEventArgs e)
        {
            FrameBotones.Navigate(new AltaProdDepto());
        }
        private void BtnBaja(object sender, RoutedEventArgs e)
        {
            FrameBotones.Navigate(new BajaProdDepto());
        }
        private void BtnConsulta(object sender, RoutedEventArgs e)
        {
            FrameBotones.Navigate(new ConsultaProdDepto());
        }

        private void BtnSalir(object sender, RoutedEventArgs e)
        {
            MainWindow menuPrincipal = new MainWindow();
            this.Close();
            menuPrincipal.Show();
        }
    }
}
