using RPACCIA3EV.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA3EV.Servicios
{
    internal interface OperativaInterfazGerencia
    {
        /*
         * Metodo mediante el cual el usuario podra crear el pedido que desee
         * RPG-04/03/2024
         */
        public void crearPedidoProveedores(List<PedidoDto> listaPedidos);
        /*
         * Metodo mediante el cual se escribira en un fichero la informacion de numero de ventas registradas
         * RPG-04/03/2024
         */
        public void mostrarVentasFichero(List<VentaDto> listaVentas);
    }
}
