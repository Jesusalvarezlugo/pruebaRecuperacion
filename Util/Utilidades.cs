using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRecuperacion.Util
{
    internal class Utilidades
    {
        public static String nombreFichero()
        {
            DateTime fechaActual = DateTime.Now;

            String nombreF = String.Concat("log-", fechaActual.ToString("ddMMyyyy"), ".txt");

            return nombreF;
        }
    }
}
