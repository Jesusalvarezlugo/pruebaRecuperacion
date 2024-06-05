using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRecuperacion.Dtos
{
    internal class VentaDto
    {
        //Atributos

        long idVenta;
        double importeVenta = 0.0;
        DateTime fechaVenta;

        //Getters y Setters
        public long IdVenta { get => idVenta; set => idVenta = value; }
        public double ImporteVenta { get => importeVenta; set => importeVenta = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
    }
}
