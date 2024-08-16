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

namespace Practica1.View.Departamentos
{
    /// <summary>
    /// Lógica de interacción para AltaDepto.xaml
    /// </summary>
    public partial class AltaDepto : Page
    {
        public AltaDepto()
        {
            InitializeComponent();
        }

        private void BtnAgregarDepto(object sender, RoutedEventArgs e)
        {
            string claveDepto = txtClave.Text.ToString();
            string nombreDepto = txtDepto.Text.ToString();
            string jefe = txtJefe.Text.ToString();
            CtrDepartamento controlador = new CtrDepartamento();
            if (controlador.altaDepto(claveDepto, nombreDepto, jefe))
                lbNotificacionAltaProducto.Content = "El departamento " + nombreDepto + " fue dado de alta con éxito.";
            else
                lbNotificacionAltaProducto.Content = "El departamento no pudo ser registrado.";
            lbNotificacionAltaProducto.Visibility = Visibility.Visible;
        }
    }
}
