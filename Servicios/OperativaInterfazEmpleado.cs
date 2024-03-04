using RPACCIA3EV.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA3EV.Servicios
{
    internal interface OperativaInterfazEmpleado
    {
        /*
         * Metodo mediante el cual el usuario podra añadir ventas
         * RPG-04/03/2024
         */
        public void añadirVenta(List<VentaDto> listaVentas);
        /*
         * Metodo mediante el cual el usuario podra saber el numer de ventas diarias
         * RPG-04/03/2024
         */
        public int calculoVentas(List<VentaDto> listaVentas);
    }
}
