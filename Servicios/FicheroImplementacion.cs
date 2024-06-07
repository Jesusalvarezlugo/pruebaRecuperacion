using PruebaRecuperacion.Controladores;
using PruebaRecuperacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRecuperacion.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void escribirEnFicheroLog(String texto)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Program.rutaFichero, true);

                sw.WriteLine(texto);

                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al escribir en el fichero log.");
            }
        }

        public void escribirEnFicheros(String rutaFichero)
        {
            try
            {
                StreamWriter sw = new StreamWriter(rutaFichero, true);

                foreach (ProductoDto producto in Program.listaProductos)
                {
                    sw.Write(producto.ToString());
                }

                sw.Close();
            }
            catch (IOException e)
            {
                escribirEnFicheroLog("Error al imprimir las listas.");
            }
            
        }
    }
}
