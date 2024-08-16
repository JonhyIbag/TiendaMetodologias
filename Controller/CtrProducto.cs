using Practica1.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Controller
{
    internal class CtrProducto
    {
        private static string ruta = @"C:\Users\jonhy\OneDrive\Escritorio\Trimestre IX\Metodologias\Practica1\Txt\Productos.txt";
        public bool bajaProducto(int claveProd)
        {
            //int claveProd;
            ArrayList productosString = new ArrayList();
            ArrayList productos = new ArrayList();
            LectorDeArchivo lectorDeArchivo = new LectorDeArchivo(ruta);

            productosString = lectorDeArchivo.LeerArchivo();
            productos = extraerDatosProducto(productosString);

            bool encontrado = false;
            int indice = 0;
            for (int i = 0; i < productos.Count; i++)
            {
                Producto productoAuxiliar = (Producto)productos[i];
                if (productoAuxiliar.getClaveProd() == claveProd)
                {
                    encontrado = true;
                    indice = i;
                }
            }
            if (encontrado)
            {
                productosString.RemoveAt(indice);
                productos.RemoveAt(indice);
                actualizarProductos(productos);
                return encontrado;
            }
            else
                return encontrado;
        }

        public ArrayList consultarProductos()
        {
            ArrayList productos = new ArrayList();
            LectorDeArchivo lectorDeArchivo = new LectorDeArchivo(ruta);
            productos = lectorDeArchivo.LeerArchivo();
            return productos;
        }

        public bool altaProducto(string nombreProducto, string proovedor)
        {
            int claveProd;
            bool exito=false;

            claveProd = generarClaveProd();

            Producto producto = new Producto(claveProd, nombreProducto, proovedor);
            FileStream archivo = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            if (producto.guardarEnArchivo(archivo))
                exito=true;
            else
                exito=false;
            archivo.Close();
            return exito;
        }

        public ArrayList extraerDatosProducto(ArrayList productosString)
        {
            ArrayList productos = new ArrayList();
            Producto producto;
            string linea = null;
            string[] tokensLinea = null;
            string claveProd;
            tokensLinea = new string[8];

            for (int i = 0; i < productosString.Count; i++)
            {
                linea = (String)productosString[i];
                producto = new Producto();
                tokensLinea = linea.Split(", ");
                claveProd = tokensLinea[0];
                producto.setClaveProd(int.Parse(claveProd));
                producto.setNombreProducto(tokensLinea[1]);
                producto.setProovedor(tokensLinea[2]);

                productos.Add(producto);
            }
            return productos;
        }

        private static void actualizarProductos(ArrayList productos)
        {
            File.Delete(ruta);
            FileStream archivo = null;

            Producto producto = new Producto();

            for (int i = 0; i < productos.Count; i++)
            {
                archivo = new FileStream(ruta, FileMode.Append, FileAccess.Write); 
                producto = (Producto)productos[i];
                producto.guardarEnArchivo(archivo);
            }
            archivo.Close();
        }

        private int generarClaveProd()
        {
            int clave = 0;
            ArrayList productosString = new ArrayList();
            ArrayList productos = new ArrayList();
            LectorDeArchivo lectorDeArchivo = new LectorDeArchivo(ruta);
            productosString = lectorDeArchivo.LeerArchivo();



            productos = this.extraerDatosProducto(productosString);
            if (productos.Count == 0)
                clave = 1;
            else
            {
                Producto ultimoProducto = (Producto)productos[productos.Count - 1];
                clave = ultimoProducto.getClaveProd();
                clave = clave + 1;
            }
            return clave;

        }
    }
}
