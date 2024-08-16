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
    internal class CtrDepartamento
    {
        private static string ruta = @"C:\Users\jonhy\OneDrive\Escritorio\Trimestre IX\Metodologias\Practica1\Txt\Deptos.txt";
        public bool bajaDepto(string claveDepto)
        {
            //int claveProd;
            ArrayList deptosString = new ArrayList();
            ArrayList deptos = new ArrayList();
            LectorDeArchivo lectorDeArchivo = new LectorDeArchivo(ruta);

            deptosString = lectorDeArchivo.LeerArchivo();
            deptos = extraerDatosDepto(deptosString);

            bool encontrado = false;
            int indice = 0;
            for (int i = 0; i < deptos.Count; i++)
            {
                Departamento deptoAuxiliar = (Departamento)deptos[i];
                if (deptoAuxiliar.getClaveDepto() == claveDepto)
                {
                    encontrado = true;
                    indice = i;
                }
            }
            if (encontrado)
            {
                deptosString.RemoveAt(indice);
                deptos.RemoveAt(indice);
                actualizarDeptos(deptos);
                return encontrado;
            }
            else
                return encontrado;
        }

        public ArrayList consultarDeptos()
        {
            ArrayList productos = new ArrayList();
            LectorDeArchivo lectorDeArchivo = new LectorDeArchivo(ruta);
            productos = lectorDeArchivo.LeerArchivo();
            return productos;
        }

        public bool altaDepto(string claveDepto, string nombreDepto, string jefe)
        {
            bool exito=false;
            string nombreArchivo = @"C:\Users\jonhy\OneDrive\Escritorio\Trimestre IX\Metodologias\Practica1\Txt\"+ claveDepto + "ProductosDepto.txt";

            Departamento departamento = new Departamento(claveDepto, nombreDepto, jefe);
            FileStream archivo = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            if (departamento.guardarEnArchivo(archivo))
            {
                if(creaArchivoProductos(nombreArchivo))
                    exito = true;
            }
            archivo.Close();
            return exito;
        }

        private bool creaArchivoProductos(string ruta)
        {
            bool exito = false;
            try
            {
                FileStream archivoProductos = new FileStream(ruta, FileMode.OpenOrCreate);
                exito = true;
                return exito;
            }
            catch (Exception ex)
            {
                return exito;
            }
        }

        private static ArrayList extraerDatosDepto(ArrayList departamentostosString)
        {
            ArrayList departamentos = new ArrayList();
            Departamento departamento;
            string ?linea = null;
            string[] ?tokensLinea = null;
            string claveDepto;
            tokensLinea = new string[8];

            for (int i = 0; i < departamentostosString.Count; i++)
            {
                linea = (String)departamentostosString[i];
                departamento = new Departamento();
                tokensLinea = linea.Split(", ");
                claveDepto = tokensLinea[0];
                departamento.setClaveDepto(claveDepto);
                departamento.setNombreDepto(tokensLinea[1]);
                departamento.setJefe(tokensLinea[2]);

                departamentos.Add(departamento);
            }
            return departamentos;
        }

        private static void actualizarDeptos(ArrayList deptos)
        {
            File.Delete(ruta);
            FileStream archivo = null;

            Departamento depto = new Departamento();

            for (int i = 0; i < deptos.Count; i++)
            {
                archivo = new FileStream(ruta, FileMode.Append, FileAccess.Write);
                depto = (Departamento)deptos[i];
                depto.guardarEnArchivo(archivo);
            }
            archivo.Close();
        }

        private static int generarClaveDepto()
        {
            int clave = 0;
            ArrayList productosString = new ArrayList();
            ArrayList productos = new ArrayList();
            LectorDeArchivo lectorDeArchivo = new LectorDeArchivo(ruta);
            productosString = lectorDeArchivo.LeerArchivo();



            productos = extraerDatosDepto(productosString);
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
