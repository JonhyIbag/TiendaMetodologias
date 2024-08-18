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
using System.Windows.Shapes;

namespace Practica1.View.Asignaciones
{
    /// <summary>
    /// Lógica de interacción para MostrarProductos.xaml
    /// </summary>
    public partial class MostrarProductos : Window
    {
        public MostrarProductos(ArrayList asignaciones)
        {
            InitializeComponent();
            this.Content = grListaProductos;
            if (asignaciones == null || asignaciones.Count==0)
            {
                Label label = new Label();
                label.Content = "No hay productos registrados";
                label.HorizontalAlignment = HorizontalAlignment.Left;
                label.Margin = new Thickness(0, 10, 0, 0);
                label.Visibility = Visibility.Visible;
                grListaProductos.Children.Add(label);
            }
            else
            {
                for (int i = 0; i < asignaciones.Count; i++)
                {
                    Label label = new Label();
                    label.Content = asignaciones[i];
                    label.HorizontalAlignment = HorizontalAlignment.Left;
                    label.Margin = new Thickness(0, 10, 0, 0);
                    label.Visibility = Visibility.Visible;
                    grListaProductos.Children.Add(label);
                }
            }
        }
    }
}
