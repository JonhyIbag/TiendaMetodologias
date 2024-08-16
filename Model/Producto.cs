using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Model
{
    internal class Producto
    {
        private int claveProd;
        private string nombreProducto;
        private string proveedor;

        public Producto()
        { }
        public Producto(int claveProd, string nombreProducto, string proovedor)
        {
            this.claveProd = claveProd;
            this.nombreProducto = nombreProducto;
            this.proveedor = proovedor;
        }

        public bool guardarEnArchivo(FileStream ruta)
        {
            bool exito = false;
            try
            {
                using (StreamWriter archivo = new StreamWriter(ruta))
                {
                    archivo.WriteLine(this.claveProd + ", " + this.nombreProducto + ", " + this.proveedor);
                }
                exito = true;
                return exito;
            }
            catch (Exception ex)
            {
                return exito;
            }
        }

        public int getClaveProd()
        {
            return this.claveProd;
        }
        public string getNombreProducto()
        {
            return this.nombreProducto;
        }
        public string getProovedor()
        {
            return this.proveedor;
        }

        public void setClaveProd(int claveProd)
        {
            this.claveProd = claveProd;
        }
        public void setNombreProducto(string nombreProducto)
        {
            this.nombreProducto = nombreProducto;
        }
        public void setProovedor(string proovedor)
        {
            this.proveedor = proovedor;
        }
    }
}
