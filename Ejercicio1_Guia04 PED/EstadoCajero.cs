using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Guia04_PED
{
    internal class EstadoCajero
    {
        //crear la variable para almacenar el estado actual
        //Disponible, Atendiendo, Ocupado
        public string estado;
        public EstadoCajero(string estado)
        {
            this.estado = estado;
        }
 
    }
}
