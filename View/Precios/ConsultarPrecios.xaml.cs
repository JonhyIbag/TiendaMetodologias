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

namespace Practica1.View.Precios
{
    /// <summary>
    /// Lógica de interacción para ConsultarPrecios.xaml
    /// </summary>
    public partial class ConsultarPrecios : Page
    {
        public ConsultarPrecios()
        {
            InitializeComponent();
        }
        private void BtnConsultar(object sender, RoutedEventArgs e)
        {
            string claveDepto = txtClaveDepto.Text.ToString();
            CtrAsignaciones controlador = new CtrAsignaciones();
            int resultado = controlador.operacion("", claveDepto, 5, -1);
            if (resultado == 1)
                lbNotificacionAltaProducto.Content = "Los productos del departamento con clave " + claveDepto + " son los siguientes.";
            else if (resultado == 3)
                lbNotificacionAltaProducto.Content = "El departamento con clave " + claveDepto + " no existe.";
            lbNotificacionAltaProducto.Visibility = Visibility.Visible;
        }
    }
}
