using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA3EV.Dtos
{
    internal class PedidoDto
    {
        //Atributos
        long idPedido;
        string nombreProducto="aaaaa";
        int cantidadProducto=0;
        DateTime fechaDeseadaEntregaProducto;

        //Metodos Getters y Setters (get=lectura set=escritura)
        public long IdPedido { get => idPedido; set => idPedido = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime FechaDeseadaEntregaProducto { get => fechaDeseadaEntregaProducto; set => fechaDeseadaEntregaProducto = value; }

        //Constructor con todos los campos
        public PedidoDto(long idPedido, string nombreProducto, int cantidadProducto, DateTime fechaDeseadaEntregaProducto)
        {
            IdPedido = idPedido;
            NombreProducto = nombreProducto;
            CantidadProducto = cantidadProducto;
            FechaDeseadaEntregaProducto = fechaDeseadaEntregaProducto;
        }

        //Al definir un constructor con todos los campos, hay que añadir el constructor vacio de manera explicita
        public PedidoDto()
        {
        }

        //Metodo ToString
        override
        public string ToString()
        {
            string elementoString = "[ Id: " + this.IdPedido + " Nombre del producto: " +
                this.NombreProducto + " Cantidad: " + this.CantidadProducto + " Fecha deseada para que el " +
                "producto sea entregado: " + this.FechaDeseadaEntregaProducto + " ]";

            return elementoString;
        }
    }
}
