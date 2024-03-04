using RPACCIA3EV.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA3EV.Servicios
{
    internal class OperativaImplementacionGerencia:OperativaInterfazGerencia
    {
        public void crearPedidoProveedores(List<PedidoDto> listaPedidos)
        {
            PedidoDto nuevoPedido = new PedidoDto();

            nuevoPedido.IdPedido = generarId(listaPedidos);
            Console.WriteLine("Indique el nombre del producto: ");
            nuevoPedido.NombreProducto = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Indique la cantidad que desea de dicho producto: ");
            nuevoPedido.CantidadProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique la fecha a la que desea recibir el producto (dia/mes/año): ");
            nuevoPedido.FechaDeseadaEntregaProducto = Convert.ToDateTime(Console.ReadLine());

            listaPedidos.Add(nuevoPedido);
        }

        //Metodo que genera el id automatico
        private long generarId(List<PedidoDto> listaPedidos)
        {
            long idCalculado;
            int tamanioLista = listaPedidos.Count();

            if (tamanioLista == 0)
            {
                idCalculado = 1;
            }
            else
            {
                idCalculado = listaPedidos[tamanioLista - 1].IdPedido + 1;
            }

            return idCalculado;
        }

        public void mostrarVentasFichero(List<VentaDto> listaVentas)
        {
            string rutaFichero = "C:\\Users\\ruben\\Desktop\\Programacion\\";
            string nombreFichero = "ddMMyyyy.txt";

            Console.WriteLine("Introduzca la fecha que desee (dia/mes/año): ");
            DateTime fecha=Convert.ToDateTime(Console.ReadLine());

            using(StreamWriter sw=new StreamWriter(rutaFichero))
            {
                sw.WriteLine(listaVentas);
            }
        }
    }
}
