using RPACCIA3EV.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA3EV.Servicios
{
    internal class MenuImplementacion: MenuInterfaz
    {
        List<VentaDto> listaVentas = new List<VentaDto>();
        List<PedidoDto> listaPedidos = new List<PedidoDto>();

        OperativaInterfazEmpleado oie = new OperativaImplementacionEmpleado();
        OperativaInterfazGerencia oig = new OperativaImplementacionGerencia();
        public int menuPrincipal()
        {
            int opcionPrincipal;

            Console.WriteLine("-----------------------");
            Console.WriteLine("0. Cerrar menu.");
            Console.WriteLine("1. Menu empleado.");
            Console.WriteLine("2. Menu gerencia.");
            Console.WriteLine("-----------------------");

            opcionPrincipal = Console.ReadKey(true).KeyChar - ('0');

            return opcionPrincipal;
        }

        public int menuEmpleado()
        {
            int opcionEmpleado;

            Console.WriteLine("-----------------------");
            Console.WriteLine("0. Menu principal.");
            Console.WriteLine("1. Añadir venta.");
            Console.WriteLine("2. Calculo total de ventas diarias.");
            Console.WriteLine("-----------------------");

            opcionEmpleado = Console.ReadKey(true).KeyChar - ('0');

            if (opcionEmpleado == 0)
            {
                menuPrincipal();
            }
            else if(opcionEmpleado == 1)
            {
                oie.añadirVenta(listaVentas);
            }
            else if (opcionEmpleado == 2)
            {
                oie.calculoVentas(listaVentas);
            }
            else
            {
                Console.WriteLine("La opcion introducida no existe.");
            }

            return opcionEmpleado;
        }

        public int menuGerencia()
        {
            int opcionGerencia;

            Console.WriteLine("-----------------------");
            Console.WriteLine("0. Menu principal.");
            Console.WriteLine("1. Crear nuevo pedido para proveedores.");
            Console.WriteLine("2. Mostrar ventas diarias (fichero).");
            Console.WriteLine("-----------------------");

            opcionGerencia = Console.ReadKey(true).KeyChar - ('0');

            if (opcionGerencia == 0)
            {
                menuPrincipal();
            }
            else if (opcionGerencia == 1)
            {
                oig.crearPedidoProveedores(listaPedidos);

                //Codigo que ejecutara un metodo o otro segun la respuesta del usuario
                Console.WriteLine("¿Desea adquirir mas productos? (si/no)");
                string respuesta = Convert.ToString(Console.ReadLine());
                if (respuesta.Equals("si"))
                {
                    oig.crearPedidoProveedores(listaPedidos);
                }
                else if (respuesta.Equals("no"))
                {
                    menuPrincipal();
                }
                else
                {
                    Console.WriteLine("La opcion introducida no existe.");
                    oig.crearPedidoProveedores(listaPedidos);
                }
            }
            else if (opcionGerencia == 2)
            {
                oig.mostrarVentasFichero(listaVentas);
            }
            else
            {
                Console.WriteLine("La opcion introducida no existe.");
            }

            return opcionGerencia;
        }
    }
}
