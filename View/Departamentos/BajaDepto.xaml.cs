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
    /// Lógica de interacción para BajaDepto.xaml
    /// </summary>
    public partial class BajaDepto : Page
    {
        public BajaDepto()
        {
            InitializeComponent();
        }
        private void BtnEliminarDepto(object sender, RoutedEventArgs e)
        {
            string claveDepto = txtClaveDepto.Text.ToString();
            CtrDepartamento controlador = new CtrDepartamento();
            if (controlador.bajaDepto(claveDepto))
                lbNotificacionBajaDepartamento.Content = "El departamento con clave " + claveDepto + " fue dado de baja con éxito.";
            else
                lbNotificacionBajaDepartamento.Content = "El departamento no pudo ser encontrado.";
            lbNotificacionBajaDepartamento.Visibility = Visibility.Visible;
        }
    }
}
