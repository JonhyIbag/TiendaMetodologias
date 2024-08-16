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

namespace Practica1.View
{
    /// <summary>
    /// Lógica de interacción para BajaProducto.xaml
    /// </summary>
    public partial class BajaProducto : Page
    {
        public BajaProducto()
        {
            InitializeComponent();
        }

        private void BtnEliminarProducto(object sender, RoutedEventArgs e)
        {
            int claveProducto = int.Parse(txtClaveProducto.Text.ToString());
            CtrProducto controlador = new CtrProducto();
            if (controlador.bajaProducto(claveProducto))
                lbNotificacionBajaProducto.Content = "El producto con clave " + claveProducto + " fue dado de baja con éxito.";
            else
                lbNotificacionBajaProducto.Content = "El producto no pudo ser encontrado.";
            lbNotificacionBajaProducto.Visibility = Visibility.Visible;
        }
    }
    
}
