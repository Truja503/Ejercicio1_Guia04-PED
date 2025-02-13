using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Guia04_PED
{
    public partial class Form1 : Form
    {
        Cajero cajero1;
        Cajero cajero2;
        Cajero cajero3;
        int turno=1;
        public Form1()
        {
            InitializeComponent();

            cajero1 = new Cajero("Ani", "Alfaro", listBox1, lstClientesAtendidos);
            lblCajero1.Text = cajero1.Nom + " " +  cajero1.Apell;

            cajero2 = new Cajero("Maria", "Perez", listBox2, lstClientesAtendidos);
            lblCajero2.Text = cajero2.Nom + " " + cajero2.Apell;

            cajero3 = new Cajero("Isaias", "Hernandez", listBox3, lstClientesAtendidos);
            lblCajero3.Text = cajero3.Nom + " " + cajero3.Apell;
        }

        private void btnAgregarACola_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();


            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
            {
                Cliente cliente = new Cliente(nombre, apellido);

                int cantidadCajero1 = cajero1.totClientesEnCola();
                int cantidadCajero2 = cajero2.totClientesEnCola();
                int cantidadCajero3 = cajero3.totClientesEnCola();

                if (cantidadCajero1 <= cantidadCajero2 && cantidadCajero1 <= cantidadCajero3)
                {
                    cajero1.EncolarCliente(cliente);
                    cajero1.ActualizarClientesenEspera();

                }
                else if (cantidadCajero2 <= cantidadCajero1 && cantidadCajero2 <= cantidadCajero3)
                {
                    cajero2.EncolarCliente(cliente);
                    cajero2.ActualizarClientesenEspera();
                }
                else if (cantidadCajero3 <= cantidadCajero2 && cantidadCajero3 <= cantidadCajero1)
                {
                    cajero3.EncolarCliente(cliente);
                    cajero3.ActualizarClientesenEspera();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese nombre y apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnAbrirSucursal_Click(object sender, EventArgs e)
        {
            label3.Text = "Estado: Abierta";
            label3.BackColor = Color.Green;
            btnAgregarACola.Enabled = true;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAgregarACola.Enabled = false;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
        }
    }
}
