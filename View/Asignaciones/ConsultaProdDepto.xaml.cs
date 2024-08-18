using Practica1.Controller;
using Practica1.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica1.View.Asignaciones
{
    /// <summary>
    /// Lógica de interacción para ConsultaProdDepto.xaml
    /// </summary>
    public partial class ConsultaProdDepto : Page
    {
        public ConsultaProdDepto()
        {
            InitializeComponent();
        }

        private void BtnConsultar(object sender, RoutedEventArgs e)
        {
            string claveDepto = txtClaveDepto.Text.ToString();
            CtrAsignaciones controlador = new CtrAsignaciones();
            int resultado = controlador.operacion("", claveDepto, 3, -1);
            if (resultado == 1)
                lbNotificacionAltaProducto.Content = "Los productos del departamento con clave " + claveDepto + " son los siguientes.";
            else if (resultado == 3)
                lbNotificacionAltaProducto.Content = "El departamento con clave " + claveDepto + " no existe.";
            lbNotificacionAltaProducto.Visibility = Visibility.Visible;
        }
    }
}
