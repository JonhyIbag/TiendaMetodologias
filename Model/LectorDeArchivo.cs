using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Model
{
    internal class LectorDeArchivo
    {
        private String nombreArchivo;

        public LectorDeArchivo(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
        }

        public ArrayList LeerArchivo()
        {
            ArrayList lectura = new ArrayList();
            FileStream archivo = null;
            StreamReader lectorArchivo = null;
            try
            {
                archivo = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
                lectorArchivo = new StreamReader(archivo);
                string linea;
                while ((linea = (string)lectorArchivo.ReadLine()) != null)
                    lectura.Add(linea);
                archivo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo convertir el archivo.");
            }
            finally
            {
                try
                {
                    if (lectorArchivo != null)
                        lectorArchivo.Close();
                }
                catch
                {
                    Console.WriteLine("No se pudo cerrar el archivo.");
                }
            }
            return lectura;
        }
    }
}
