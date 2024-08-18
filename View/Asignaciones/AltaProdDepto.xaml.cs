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
    /// Lógica de interacción para AltaProdDepto.xaml
    /// </summary>
    public partial class AltaProdDepto : Page
    {
        public AltaProdDepto()
        {
            InitializeComponent();
        }

        private void BtnAgregar(object sender, RoutedEventArgs e)
        {
            string claveDepto = txtClaveDepto.Text.ToString();
            string claveProd = txtClaveProd.Text.ToString();
            CtrAsignaciones controlador = new CtrAsignaciones();
            int resultado = controlador.operacion(claveProd, claveDepto, 1, -1);
            if (resultado==1)
                lbNotificacionAltaProducto.Content = "El producto con clave " + claveProd + " fue asignado al departamento " + claveDepto + " con éxito.";
            else if (resultado== 2)
                lbNotificacionAltaProducto.Content = "El producto con clave " + claveProd + " no existe.";
            else if (resultado == 3)
                lbNotificacionAltaProducto.Content = "El departamento con clave " + claveDepto + " no existe.";
            else
                lbNotificacionAltaProducto.Content = "El producto con clave " + claveProd + " ya estaba asignado al departamento " + claveDepto;
            lbNotificacionAltaProducto.Visibility = Visibility.Visible;
        }
    }
}
