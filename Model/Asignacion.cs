using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Model
{
    class Asignacion
    {
        int claveProd;
        double precio;
        string claveDepto;

        public Asignacion() { }

        public Asignacion(int claveProd, double precio, string claveDepto)
        {
            this.claveProd = claveProd;
            this.precio = precio;
            this.claveDepto = claveDepto;
        }

        public Asignacion(Asignacion prodEnDepto)
        { }

        public bool guardarEnArchivo(FileStream ruta)
        {
            bool exito = false;
            try
            {
                using (StreamWriter archivo = new StreamWriter(ruta))
                {
                    archivo.WriteLine(this.claveProd + ", " + this.precio + ", " + this.claveDepto);
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
        public double getPrecio()
        {
            return this.precio;
        }
        public string getClaveDepto()
        {
            return this.claveDepto;
        }

        public void setClaveProd(int claveProd)
        {
            this.claveProd = claveProd;
        }
        public void setPrecio(double precio)
        {
            this.precio = precio;
        }
        public void setClaveDepto(string claveDepto)
        {
            this.claveDepto = claveDepto;
        }
    }
}
