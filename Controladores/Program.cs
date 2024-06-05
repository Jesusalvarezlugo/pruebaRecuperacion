using PruebaRecuperacion.Dtos;
using PruebaRecuperacion.Servicios;

namespace PruebaRecuperacion.Controladores
{
    class Program
    {
        public static List<VentaDto> listaVentas = new List<VentaDto>();
        public static List<ProductoDto> listaProductos = new List<ProductoDto>();
        public static void Main(string[] args)
        {
            MenuInterfaz mi= new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            int opcionS;
            bool cerrarMenu = false;

            do
            {
                try
                {
                    opcionS = mi.mostrarMenuYSeleccionPrin();

                    switch(opcionS)
                    {
                        case 0:
                            Console.WriteLine("Se cerrara la app");
                            cerrarMenu=true;
                            break;

                        case 1:
                            Console.WriteLine("Se accedera al menu de empleados.");
                            oi.menuEmp();
                            break;

                        case 2:
                            Console.WriteLine("Se accedera al menu de gerencia.");
                            oi.menuGer();
                            break;
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine("Error en alguna funcionalidad del codigo.");
                }
            }while(!cerrarMenu);
        }
    }
}
