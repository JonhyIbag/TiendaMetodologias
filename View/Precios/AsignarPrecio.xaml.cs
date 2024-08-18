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
    /// Lógica de interacción para AsignarPrecio.xaml
    /// </summary>
    public partial class AsignarPrecio : Page
    {
        public AsignarPrecio()
        {
            InitializeComponent();
        }

        private void BtnAgregarPrecio(object sender, RoutedEventArgs e)
        {
            string claveDepto = txtClaveDepto.Text.ToString();
            string claveProd = txtClaveProd.Text.ToString();
            double precio = double.Parse(txtPrecio.Text.ToString());
            CtrAsignaciones controlador = new CtrAsignaciones();
            int resultado = controlador.operacion(claveProd, claveDepto, 4, precio);
            if (resultado == 1)
                lbNotificacionPrecio.Content = "Se modifico el precio del producto con clave " + claveProd + " en el departamento " + claveDepto + " con éxito.";
            else if (resultado == 2)
                lbNotificacionPrecio.Content = "El producto con clave " + claveProd + " no existe.";
            else if (resultado == 3)
                lbNotificacionPrecio.Content = "El departamento con clave " + claveDepto + " no existe.";
            else
                lbNotificacionPrecio.Content = "El producto con clave " + claveProd + " no se encuentra en el departamento " + claveDepto + ".";
            lbNotificacionPrecio.Visibility = Visibility.Visible;
        }
    }
}
