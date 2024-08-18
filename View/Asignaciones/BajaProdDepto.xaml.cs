using Practica1.Controller;
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

namespace Practica1.View.Asignaciones
{
    /// <summary>
    /// Lógica de interacción para BajaProdDepto.xaml
    /// </summary>
    public partial class BajaProdDepto : Page
    {
        public BajaProdDepto()
        {
            InitializeComponent();
        }

        private void BtnEliminar(object sender, RoutedEventArgs e)
        {
            string claveDepto = txtClaveDepto.Text.ToString();
            string claveProd = txtClaveProd.Text.ToString();
            CtrAsignaciones controlador = new CtrAsignaciones();
            int resultado = controlador.baja(claveProd, claveDepto);
            if (resultado == 1)
                lbNotificacionBajaProducto.Content = "El producto con clave " + claveProd + " fue eliminado del departamento " + claveDepto + " con éxito.";
            else if (resultado == 2)
                lbNotificacionBajaProducto.Content = "El producto con clave " + claveProd + " no existe.";
            else if (resultado == 3)
                lbNotificacionBajaProducto.Content = "El departamento con clave " + claveDepto + " no existe.";
            else
                lbNotificacionBajaProducto.Content = "El producto con clave " + claveProd + " no pudo ser eliminado del departamento " + claveDepto;
            lbNotificacionBajaProducto.Visibility = Visibility.Visible;
        }
    }
}
