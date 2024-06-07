using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRecuperacion.Servicios
{
    internal interface FicheroInterfaz
    {
        public void escribirEnFicheroLog(String texto);

        public void escribirEnFicheros(String rutaFichero);
        
    }
}
