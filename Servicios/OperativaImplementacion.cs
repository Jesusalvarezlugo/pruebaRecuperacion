using PruebaRecuperacion.Controladores;
using PruebaRecuperacion.Dtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRecuperacion.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void aniadirVenta()
        {
            VentaDto nuevaVenta= new VentaDto();

            Console.WriteLine("Introduzca el importe de la venta: ");
            nuevaVenta.ImporteVenta=Double.Parse(Console.ReadLine());
            nuevaVenta.IdVenta = iDAuto();
            nuevaVenta.FechaVenta=DateTime.Now;

            Program.listaVentas.Add(nuevaVenta);
        }

        public void calculoVentasDiario()
        {
            VentaDto ventaAux= new VentaDto();
            DateTime fechaAPedir;
            bool aux=false;
            TimeSpan tiempoTranscurrido;
            Console.WriteLine("Introduzca la fecha para calcular la venta del dia (dd-MM-yyyy)");
            fechaAPedir = Convert.ToDateTime(Console.ReadLine());
            List<VentaDto> listaAuxiliar=new List<VentaDto>();
            foreach(VentaDto venta in Program.listaVentas)
            {
                if (fechaAPedir.Date.ToString("dd-MM-yyyy") == venta.FechaVenta.Date.ToString("dd-MM-yyyy"))
                {
                    
                    venta.ImporteVenta += venta.ImporteVenta;
                    ventaAux=venta;
                    listaAuxiliar.Add(ventaAux);
                    aux = true;
                }
            }

            tiempoTranscurrido = listaAuxiliar[0].FechaVenta - listaAuxiliar[listaAuxiliar.Count - 1].FechaVenta;

            
            if (aux = false)
            {
                Console.WriteLine("No hay ventas para ese dia.");
            }
            else
            {
                Console.WriteLine(String.Concat("Total ventas: ", ventaAux.ImporteVenta));
                Console.WriteLine(String.Concat("Tiempo Transcurrido: "),tiempoTranscurrido.TotalDays,"Horas ",tiempoTranscurrido.TotalMinutes," minutos",tiempoTranscurrido.TotalSeconds," segundos");
            }

            
            

        }

        public void menuEmp()
        {
            MenuInterfaz mi = new MenuImplementacion();
            int opcionS;
            bool cerrarMenuEmp = false;

            while (!cerrarMenuEmp)
            {
                try
                {
                    opcionS = mi.mostrarMenuYSeleccionEmp();

                    switch (opcionS)
                    {
                        case 0:
                            Console.WriteLine("Se volvera al menu principal");
                            cerrarMenuEmp = true;
                            break;

                        case 1:
                            Console.WriteLine("Se aniadira una venta");
                            aniadirVenta();
                            break;

                        case 2:
                            Console.WriteLine("Se calculara el total de ventas diario");
                            calculoVentasDiario();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en el menu de empleados");
                }
                
            }
        }

        public void menuGer()
        {
            MenuInterfaz mi = new MenuImplementacion();
            int opcionS;
            bool cerrarMenuGer = false;

            while (!cerrarMenuGer)
            {
                opcionS=mi.mostrarMenuYSeleccionGer();

                switch (opcionS)
                {
                    case 0:
                        Console.WriteLine("Se volvera al menu principal");
                        cerrarMenuGer = true;
                        break;

                    case 1:
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Escribir en un fichero todas las ventas");
                        break;
                }
            }
        }

        private void escribirVentasEnFichero()
        {
            DateTime fechaAPedir;
            string formato = "dd-MM-yyyy";
            CultureInfo proveedor = new CultureInfo("en-US");

            Console.WriteLine("Introduzca la fecha para escribir las ventas (dd-MM-yyyy): ");
            fechaAPedir=DateTime.ParseExact(Console.ReadLine(),formato,proveedor);
            
            String rutaFichero = String.Concat(fechaAPedir.ToString("ddMMyyyy"), ".txt");
            StreamWriter sw = new StreamWriter(rutaFichero,true);

            foreach (VentaDto venta in Program.listaVentas)
            {
                
                if (fechaAPedir.Date.ToString("dd-MM-yyyy") == venta.FechaVenta.Date.ToString("dd-MM-yyyy"))
                {
                    sw.Write("……….\r\nVenta número: ",venta.IdVenta,"\r\nEuros:",venta.ImporteVenta,"\r\nInstante de compra:",venta.FechaVenta, "\r\n……….\r\n");
                }
            }

            sw.Close();
        }

        private long iDAuto()
        {
            int tamanioLista = Program.listaVentas.Count;
            long nuevoId;

            if(tamanioLista > 0)
            {
                nuevoId = Program.listaVentas[tamanioLista - 1].IdVenta + 1;
            }
            else
            {
                nuevoId = 1;
            }

            return nuevoId;
        }
    }
}
