using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA3EV.Dtos
{
    internal class VentaDto
    {
        //Atributos
        long idVenta;
        double importeVenta=0;
        DateTime fechaVenta= DateTime.Now;

        //Metodos Getters y Setters (get=lectura set=escritura)
        public long IdVenta { get => idVenta; set => idVenta = value; }
        public double ImporteVenta { get => importeVenta; set => importeVenta = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }

        //Constructor con todos los campos
        public VentaDto(long idVenta, double importeVenta, DateTime fechaVenta)
        {
            IdVenta = idVenta;
            ImporteVenta = importeVenta;
            FechaVenta = fechaVenta;
        }

        //Al definir un constructor con todos los campos, hay que añadir el constructor vacio de manera explicita
        public VentaDto()
        {
        }

        //Metodo ToString
        override
        public string ToString()
        {
            string elementoString = "[ Id: " + this.IdVenta + " Importe de la venta: " +
                this.ImporteVenta + " Fecha de la venta: " + this.FechaVenta + " ]";

            return elementoString;
        }
    }
}
