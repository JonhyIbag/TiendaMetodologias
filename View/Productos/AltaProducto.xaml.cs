using Practica1.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace Practica1.View
{
    /// <summary>
    /// Lógica de interacción para AltaProducto.xaml
    /// </summary>
    public partial class AltaProducto : Page
    {
        public AltaProducto()
        {
            InitializeComponent();
        }

        private void BtnAgregarProducto(object sender, RoutedEventArgs e)
        {
            string nombreProducto=txtProducto.Text.ToString();
            string proovedor = txtProovedor.Text.ToString();
            CtrProducto controlador = new CtrProducto();
            if (controlador.altaProducto(nombreProducto, proovedor))
                lbNotificacionAltaProducto.Content = "El producto " + nombreProducto + " fue dado de alta con éxito.";
            else
                lbNotificacionAltaProducto.Content = "El producto no pudo ser registrado.";
            lbNotificacionAltaProducto.Visibility= Visibility.Visible;
        }
    }
}
