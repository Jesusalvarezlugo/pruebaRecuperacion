using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRecuperacion.Dtos
{
    internal class ProductoDto
    {
        //Atributos

        long idProducto;
        long idPedido;
        string nombreProducto = "aaaaa";
        int cantidadProducto = 1;
        DateTime fechaEntrega=DateTime.Now;

        //Getters y Setters
        public long IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }

        override
            public string ToString()
        {
            string texto =String.Concat("Producto: ",nombreProducto,"\n Cantidad: ",cantidadProducto,"Fecha entrega: ",fechaEntrega);

            return texto;
        }
    }
}
