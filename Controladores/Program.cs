using RPACCIA3EV.Dtos;
using RPACCIA3EV.Servicios;

namespace RPACCIA3EV
{
    class Program
    {
        /*
         * Metodo Main: Metodo principal de la aplicacion
         * RPG-04/03/2024
         */
        static void Main(string[] args)
        {
            //Lista que contienen la informacion de las ventas
            List<VentaDto> listaVentas= new List<VentaDto>();
            //Lista que contienen la informacion de los pedidos
            List<PedidoDto> listaPedidos = new List<PedidoDto>();
            
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfazEmpleado oie= new OperativaImplementacionEmpleado();
            OperativaInterfazGerencia oig = new OperativaImplementacionGerencia();

            //Variable que controla la opcion que escoge el usuario
            int opcionUsuario;
            //Variable que controla la apertura y el cierre del menu
            bool cerrarMenu =false;

            //Bucle que controla los metodos que se deben de ejecutar en base a
            //la opcion elegida por el usuario
            while(!cerrarMenu) 
            {
                Console.WriteLine("Menu principal");
                opcionUsuario = mi.menuPrincipal();

                switch(opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Se cierra el menu.");
                        cerrarMenu = true;
                        break;
                    case 1: 
                        Console.WriteLine("Se ejecuta la opcion 1.");
                        mi.menuEmpleado();
                        break;
                    case 2:
                        Console.WriteLine("Se ejecuta la opcion 2.");
                        mi.menuGerencia();
                        break;
                    default:
                        Console.WriteLine("La opcion introducida no existe.");
                        break;
                }
            }
        }
    }
}