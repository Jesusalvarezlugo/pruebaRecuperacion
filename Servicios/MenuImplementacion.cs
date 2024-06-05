using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRecuperacion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenuYSeleccionPrin()
        {
            int opcion;

            Console.WriteLine("#####################");
            Console.WriteLine("0. Salir de la aplicacion");
            Console.WriteLine("1. Menu empleado");
            Console.WriteLine("2. Menu gerencia");
            Console.WriteLine("#####################");
            Console.WriteLine("elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
        public int mostrarMenuYSeleccionEmp()
        {
            int opcion;

            Console.WriteLine("#####################");
            Console.WriteLine("0. Salir de la aplicacion");
            Console.WriteLine("1. Añadir venta");
            Console.WriteLine("2. Cálculo total de ventas diario");
            Console.WriteLine("#####################");
            Console.WriteLine("elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        public int mostrarMenuYSeleccionGer()
        {
            int opcion;

            Console.WriteLine("#####################");
            Console.WriteLine("0. Salir de la aplicacion");
            Console.WriteLine("1. Crear un nuevo pedido");
            Console.WriteLine("2. Escribir en un fichero todas las ventas");
            Console.WriteLine("#####################");
            Console.WriteLine("elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        
    }
}
