using RPACCIA3EV.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA3EV.Servicios
{
    internal class OperativaImplementacionEmpleado:OperativaInterfazEmpleado
    {
        public void añadirVenta(List<VentaDto> listaVentas)
        {
            VentaDto nuevaVenta= new VentaDto();

            nuevaVenta.IdVenta=generarId(listaVentas);
            Console.WriteLine("Importe de la venta: ");
            nuevaVenta.ImporteVenta=Convert.ToDouble(Console.ReadLine());
            nuevaVenta.FechaVenta=DateTime.Now;

            listaVentas.Add(nuevaVenta);
        }

        //Metodo que genera el id automatico
        private long generarId(List<VentaDto> listaVentas)
        {
            long idCalculado;
            int tamanioLista= listaVentas.Count();

            if (tamanioLista == 0)
            {
                idCalculado = 1;
            }
            else
            {
                idCalculado = listaVentas[tamanioLista - 1].IdVenta + 1;
            }
            
            return idCalculado;
        }

        public int calculoVentas(List<VentaDto> listaVentas)
        {        
            int numVentas;
            numVentas = listaVentas.Count();
            Console.WriteLine("Total ventas: " + numVentas);
            return numVentas;         
        }
    }
}
