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

namespace Practica1.View
{
    /// <summary>
    /// Lógica de interacción para ConsultarProducto.xaml
    /// </summary>
    public partial class ConsultarProducto : Page
    {
        public ConsultarProducto(ArrayList productos)
        {
            InitializeComponent(); 
            this.Content = grListaProductos;
            if (productos == null)
            {
                Label label = new Label();
                label.Content = "No hay productos registrados";
                label.Visibility = Visibility.Visible;
                Console.WriteLine("No hay productos");
            }
            else
            {
                for (int i = 0; i < productos.Count; i++)
                {
                    Label label = new Label();
                    label.Content = productos[i];
                    label.HorizontalAlignment = HorizontalAlignment.Left;
                    label.Margin = new Thickness(0, 10, 0, 0);
                    label.Visibility = Visibility.Visible;
                    grListaProductos.Children.Add(label);
                }
                Console.WriteLine("Los productos existentes son: ");
                for (int i = 0; i < productos.Count; i++)
                {
                    Console.WriteLine("{0}", productos[i]);

                }
            }
            
        }
    }
}
