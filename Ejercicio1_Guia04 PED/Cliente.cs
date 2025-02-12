using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Guia04_PED
{
    public class Cliente
    {
        //atributos
        public string nom;
        public string apell;
        public Cliente clientesig = null;

        //metodos
        public Cliente(string nom, string apell)
        {
            this.nom = nom;
            this.apell = apell;
        }

        public string NombreCompleto()
        {
            return(nom + " " + apell);
        }
    }
}
