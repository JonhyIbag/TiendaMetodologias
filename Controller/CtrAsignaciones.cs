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
    class CtrAsignaciones
    {
        public int alta(string claveProd, string claveDepto)
        {
            int resultado;
            string nombreArchivo = claveDepto + "ProductosDepto.txt";

            if(existeProductosDepto(nombreArchivo))
            {
                if(productoExiste(int.Parse(claveProd)))
                {
                    if (agregarProductoAlDepto(nombreArchivo, int.Parse(claveProd), claveDepto))
                        resultado = 1; //1 es el caso exitoso
                    else
                        resultado =4 ; //4 es el caso donde existe el producto y el departamento pero no se pudo asignar en el archivo
                }
                else
                    resultado = 2;//2 es el caso donde no existe el producto
                
            }
            else
                resultado = 3;//3 es el caso donde no existe el departamento
            return resultado;
        }

        public int baja(string claveProd, string claveDepto)
        {
            int resultado;
            string nombreArchivo = claveDepto + "ProductosDepto.txt";

            if (existeProductosDepto(nombreArchivo))
            {
                if (productoExiste(int.Parse(claveProd)))
                {
                    if (borrarProductoAlDepto(nombreArchivo, int.Parse(claveProd), claveDepto))
                        resultado = 1; //1 es el caso exitoso
                    else
                        resultado = 4; //4 es el caso donde existe el producto y el departamento pero no se pudo asignar en el archivo
                }
                else
                    resultado = 2;//2 es el caso donde no existe el producto

            }
            else
                resultado = 3;//3 es el caso donde no existe el departamento
            return resultado;
        }

        private bool borrarProductoAlDepto(string nombreArchivo, int claveProd, string claveDepto)
        {
            string ruta = @"C:\Users\jonhy\OneDrive\Escritorio\Trimestre IX\Metodologias\Practica1\Txt\" + nombreArchivo;
            LectorDeArchivo lectorDeArchivo = new LectorDeArchivo(ruta); 
            ArrayList asignacionesString = lectorDeArchivo.LeerArchivo(); ;
            ArrayList asignaciones = extraerDatosProductosEnDepto(asignacionesString);
            bool encontrado = false;
            int indice = 0;

            for(int i = 0; i<asignaciones.Count; i++)
            {
                Asignacion asignacionAuxiliar = (Asignacion)asignaciones[i];
                if(asignacionAuxiliar.getClaveProd() == claveProd)
                {
                    encontrado = true;
                    indice = i;
                }
            }

            if (encontrado)
            {
                asignacionesString.RemoveAt(indice);
                asignaciones.RemoveAt(indice);
                actualizarProductosDepto(asignaciones, ruta);
                return encontrado;
            }
            else
                return encontrado;
        }

        private void actualizarProductosDepto(ArrayList asignaciones, string ruta)
        {
            File.Delete(ruta);
            FileStream archivo = null;
            Asignacion asignacion = new Asignacion();

            for(int i=0; i<asignaciones.Count; i++)
            {
                archivo = new FileStream(ruta, FileMode.Append, FileAccess.Write);
                asignacion = (Asignacion)asignaciones[i];
                asignacion.guardarEnArchivo(archivo);
            }
            archivo.Close();
        }

        public ArrayList extraerDatosProductosEnDepto(ArrayList productosEnDeptoStr)
        {
            ArrayList productosEnDepto = new ArrayList();
            Asignacion asignacion;
            string ?linea = null;
            string[] ?tokensLinea = null;
            string claveProd;
            tokensLinea = new string[8];

            for (int i = 0; i < productosEnDeptoStr.Count; i++)
            {
                linea = (String)productosEnDeptoStr[i];
                asignacion = new Asignacion();
                tokensLinea = linea.Split(", ");
                claveProd = tokensLinea[0];
                asignacion.setClaveProd(int.Parse(claveProd));
                asignacion.setPrecio(double.Parse(tokensLinea[1]));
                asignacion.setClaveDepto(tokensLinea[2]);

                productosEnDepto.Add(asignacion);
            }
            return productosEnDepto;
        }


        private bool agregarProductoAlDepto(string nombreArchivo, int claveProd, string claveDepto)
        {
            FileStream archivo = null;
            bool exito = false;
            bool yaAsignado=false;
            LectorDeArchivo lector = new LectorDeArchivo(@"C:\Users\jonhy\OneDrive\Escritorio\Trimestre IX\Metodologias\Practica1\Txt\" + nombreArchivo);
            ArrayList productosEnDeptoStr = lector.LeerArchivo();
            ArrayList productosEnDepto = extraerDatosProductosEnDepto(productosEnDeptoStr);
            archivo = new FileStream(@"C:\Users\jonhy\OneDrive\Escritorio\Trimestre IX\Metodologias\Practica1\Txt\" + nombreArchivo, FileMode.Append, FileAccess.Write);

            Asignacion auxiliar = new Asignacion();
            Asignacion asignacion = new Asignacion(claveProd, -1, claveDepto);
            
            for(int i=0; i<productosEnDepto.Count; i++)
            {
                auxiliar=(Asignacion)productosEnDepto[i];
                if(auxiliar.getClaveProd()==claveProd)
                    yaAsignado = true;
                //auxiliar.guardarEnArchivo(archivo);
            }
            if (yaAsignado)
            {
                archivo.Close();
                return false;
            }   
            else
            {
                exito = asignacion.guardarEnArchivo(archivo);
                archivo.Close();
                return exito;
            }
        }

        private bool productoExiste(int claveProd)
        {
            bool encontrado = false;
            CtrProducto ctrProducto = new CtrProducto();
            ArrayList productosString = ctrProducto.consultarProductos();
            ArrayList productos = ctrProducto.extraerDatosProducto(productosString);
            Producto producto = new Producto();

            for (int i=0; i<productos.Count; i++)
            {
                producto = (Producto)productos[i];
                if (producto.getClaveProd()==claveProd)
                    encontrado = true;
            }
            return encontrado;
        }

        private bool existeProductosDepto(string nombreArchivo)
        {
            FileStream archivo = null;
            StreamReader lectorArchivo = null;
            bool existe = false;
            try
            {
                archivo = new FileStream(@"C:\Users\jonhy\OneDrive\Escritorio\Trimestre IX\Metodologias\Practica1\Txt\" + nombreArchivo, FileMode.Open);
                lectorArchivo = new StreamReader(archivo);
                existe = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ya chicoteo");
            }
            finally
            {
                try
                {
                    if (lectorArchivo != null)
                        lectorArchivo.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return existe;
        }
    }
}
