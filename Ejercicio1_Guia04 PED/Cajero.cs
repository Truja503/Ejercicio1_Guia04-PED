using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio1_Guia04_PED
{
    internal class Cajero
    {
        //creamos los atributos para el cajero
        private String nom; //nombre del cajero
        private String apell;//apellido del cajero
        private EstadoCajero estado;//definimos el estado con la clase EstadoCajero
        private ColaCliente colaAtencion; //Cola de clientes actual
        private int tiempoatencion;
        private Timer relojatencion;//para almacenar y ejecutar cuanto tarda en atenderse
        private Random numeroaleatorio;
        private Cliente cliente_actual;
        private ListBox lstVistaCola; //lista que se muestra en la pantalla del cajero asignado
        private ListBox lstColaSalida; //para acceder a la lista donde se almacenaran todos los clientes atendidos
        private int clientesEnCola; //Conocer la cantidad de elementos en la cola

        public Cajero(string nom, string apell, ListBox VistaCola, ListBox ClientesServidos)
        {
            this.nom = nom;
            this.apell = apell;
            lstVistaCola = VistaCola;//obtener los list box donde se mostraran los datos
            lstColaSalida = ClientesServidos;//obtener el list box global donde se mostrara los clientes atendidos
            clientesEnCola = 0;
            estado = new EstadoCajero("Disponible");
            relojatencion = new Timer();
            colaAtencion = new ColaCliente();
            

        }
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Apell
        {
            get { return apell; }
            set { apell = value; }
        }

        public void EncolarCliente(Cliente nueCliente)
        {
            

            if (nueCliente != null)
            {
                colaAtencion.AgregarCli(nueCliente);  
                clientesEnCola = colaAtencion.TotalClientes;

                if (lstVistaCola != null)
                {
                    lstVistaCola.Items.Add(nueCliente.NombreCompleto());
                }
            }
        }
        public void FinalizarCliente(object sender, EventArgs e)
        {
            
           lstColaSalida.Items.Add(cliente_actual.nom + " " + cliente_actual.apell); // Mover a la lista de clientes atendidos
            colaAtencion.RemoverCli();//Eliminamos de la cola al cliente atendido
            lstVistaCola.Items.RemoveAt(0); // Eliminar el cliente de la cola de espera
          
            ActualizarClientesenEspera();
            relojatencion.Stop();
        }
        private int GenerarSemilla()
        {
            int semilla = Environment.TickCount;//Obtenemos la semilla
            return semilla;
        }
      
        public void AtenderCliente()
        {

            estado.estado = "Ocupado";
            cliente_actual = colaAtencion.ClienteInic;
            numeroaleatorio = new Random(GenerarSemilla());//creamos el objeto random
            tiempoatencion = numeroaleatorio.Next(1000, 5000);//almacenamos un numero randon de 10,000 a 50,000 
            relojatencion.Interval = tiempoatencion;//Intervalo aleatorio 

            relojatencion.Tick -= new System.EventHandler(FinalizarCliente);
            relojatencion.Tick += new System.EventHandler(FinalizarCliente);
            relojatencion.Start();

        }

        public void ActualizarClientesenEspera()
        {

            AtenderCliente();
        }
        public void ActualizarClientesSalida()
        {
            
        }
        public int totClientesEnCola()
        {
            return clientesEnCola;
        }

    }
}
