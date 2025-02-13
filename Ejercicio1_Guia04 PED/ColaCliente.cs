using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio1_Guia04_PED
{
    public class ColaCliente
    {
        //atributos
        Cliente clienteInic = null;
        Cliente clienteFin = null;
        int totalClientes = 0;

        public Cliente ClienteInic 
        {
            get {  return clienteInic; } 
            set {  clienteInic = value; }
        }
        public Cliente ClienteFin
        {
            get { return clienteFin; }
            set { clienteInic = value; }

        }
        public int TotalClientes
        {
            get { return totalClientes; }
            set
            {
                if (totalClientes >= 0)
                {
                    totalClientes = value;
                }
            }
        }

        //metodos
        //metodo constructor
        public ColaCliente()
        {
            ClienteInic = null;
            ClienteFin = null;
            TotalClientes = 0;
        }

        public int TotalCLientes()
        {
            return TotalClientes;
        }

       public void AgregarCli(Cliente nodo)
        {
            if( ClienteInic == null )
            {
                clienteInic = clienteFin = nodo;
                
            }
            else 
            {   
                clienteFin.clientesig = nodo;
                clienteFin = nodo;

            }
            totalClientes++;
        }

        public Cliente RemoverCli()
        {
            Cliente aux = null;
            if(ClienteInic != null)
            {
                aux = clienteInic;
                clienteInic = clienteInic.clientesig;
                totalClientes--;
            }
           return aux;
        }

        public void AnotarClientesEn(ListBox VistaClientes)
        {
            if (VistaClientes == null)
            {
                return; // Evita errores si la referencia es nula
            }

            Cliente actual = ClienteInic;

            while (actual != null)
            {
                VistaClientes.Items.Add(actual.NombreCompleto());
                actual = actual.clientesig;
            }
        }
    }
    
}
