using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPACCIA3EV.Servicios
{
    internal interface MenuInterfaz
    {
        /*
         * Metodo que controla el menu principal y las opciones elegidas por el usuario
         * RPG-04/03/2024
         */
        public int menuPrincipal();
        /*
         * Metodo que controla el menu del empleado y las opciones elegidas por el usuario
         * RPG-04/03/2024
         */
        public int menuEmpleado();
        /*
         * Metodo que controla el menu de la gerencia y las opciones elegidas por el usuario
         * RPG-04/03/2024
         */
        public int menuGerencia();
    }
}
