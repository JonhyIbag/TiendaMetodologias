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

namespace Practica1.View.Departamentos
{
    /// <summary>
    /// Lógica de interacción para ConsultarDepartamento.xaml
    /// </summary>
    public partial class ConsultarDepartamento : Page
    {
        public ConsultarDepartamento(ArrayList departamentos)
        {
            InitializeComponent();
            this.Content = grListaProductos;
            if (departamentos == null)
            {
                Label label = new Label();
                label.Content = "No hay departamentos registrados";
                label.Visibility = Visibility.Visible;
                Console.WriteLine("No hay departamentos");
            }
            else
            {
                for (int i = 0; i < departamentos.Count; i++)
                {
                    Label label = new Label();
                    label.Content = departamentos[i];
                    label.HorizontalAlignment = HorizontalAlignment.Left;
                    label.Margin = new Thickness(0, 10, 0, 0);
                    label.Visibility = Visibility.Visible;
                    grListaProductos.Children.Add(label);
                }
                Console.WriteLine("Los productos existentes son: ");
                for (int i = 0; i < departamentos.Count; i++)
                {
                    Console.WriteLine("{0}", departamentos[i]);

                }
            }
        }
    }
}
