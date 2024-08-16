using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Model
{
    internal class Departamento
    {
        private string claveDepto;
        private string nombreDepto;
        private string jefe;

        public Departamento()
        { }
        public Departamento(string claveDepto, string nombreDepto, string jefe)
        {
            this.claveDepto = claveDepto;
            this.nombreDepto = nombreDepto;
            this.jefe = jefe;
        }

        public bool guardarEnArchivo(FileStream ruta)
        {
            bool exito = false;
            try
            {
                using (StreamWriter archivo = new StreamWriter(ruta))
                {
                    archivo.WriteLine(this.claveDepto + ", " + this.nombreDepto + ", " + this.jefe);
                }
                exito = true;
                return exito;
            }
            catch (Exception ex)
            {
                return exito;
            }
        }

        public string getClaveDepto()
        {
            return this.claveDepto;
        }
        public string getNombreDepto()
        {
            return this.nombreDepto;
        }
        public string getJefe()
        {
            return this.jefe;
        }
        public void setClaveDepto(string claveDepto)
        {
            this.claveDepto = claveDepto;
        }
        public void setNombreDepto(string nombreDepto)
        {
            this.nombreDepto = nombreDepto;
        }
        public void setJefe(string jefe)
        {
            this.jefe = jefe;
        }
    }
}
