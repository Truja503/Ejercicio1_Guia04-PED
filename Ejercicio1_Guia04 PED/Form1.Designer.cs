﻿namespace Ejercicio1_Guia04_PED
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbrirSucursal = new System.Windows.Forms.Button();
            this.btnAgregarACola = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCajero1 = new System.Windows.Forms.Label();
            this.lblCajero2 = new System.Windows.Forms.Label();
            this.lblCajero3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.lstClientesAtendidos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCajero4 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirSucursal
            // 
            this.btnAbrirSucursal.Location = new System.Drawing.Point(300, 27);
            this.btnAbrirSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirSucursal.Name = "btnAbrirSucursal";
            this.btnAbrirSucursal.Size = new System.Drawing.Size(140, 53);
            this.btnAbrirSucursal.TabIndex = 0;
            this.btnAbrirSucursal.Text = "Abrir Sucursal";
            this.btnAbrirSucursal.UseVisualStyleBackColor = true;
            this.btnAbrirSucursal.Click += new System.EventHandler(this.btnAbrirSucursal_Click);
            // 
            // btnAgregarACola
            // 
            this.btnAgregarACola.Location = new System.Drawing.Point(19, 162);
            this.btnAgregarACola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarACola.Name = "btnAgregarACola";
            this.btnAgregarACola.Size = new System.Drawing.Size(212, 54);
            this.btnAgregarACola.TabIndex = 1;
            this.btnAgregarACola.Text = "Agregar a Cola";
            this.btnAgregarACola.UseVisualStyleBackColor = true;
            this.btnAgregarACola.Click += new System.EventHandler(this.btnAgregarACola_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(109, 107);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido:";
            // 
            // lblCajero1
            // 
            this.lblCajero1.AutoSize = true;
            this.lblCajero1.BackColor = System.Drawing.Color.Bisque;
            this.lblCajero1.Location = new System.Drawing.Point(23, 36);
            this.lblCajero1.Name = "lblCajero1";
            this.lblCajero1.Size = new System.Drawing.Size(44, 16);
            this.lblCajero1.TabIndex = 6;
            this.lblCajero1.Text = "label3";
            // 
            // lblCajero2
            // 
            this.lblCajero2.AutoSize = true;
            this.lblCajero2.BackColor = System.Drawing.Color.Bisque;
            this.lblCajero2.Location = new System.Drawing.Point(161, 34);
            this.lblCajero2.Name = "lblCajero2";
            this.lblCajero2.Size = new System.Drawing.Size(44, 16);
            this.lblCajero2.TabIndex = 7;
            this.lblCajero2.Text = "label4";
            // 
            // lblCajero3
            // 
            this.lblCajero3.AutoSize = true;
            this.lblCajero3.BackColor = System.Drawing.Color.Bisque;
            this.lblCajero3.Location = new System.Drawing.Point(293, 34);
            this.lblCajero3.Name = "lblCajero3";
            this.lblCajero3.Size = new System.Drawing.Size(44, 16);
            this.lblCajero3.TabIndex = 8;
            this.lblCajero3.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(875, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Clientes ya atendidos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(5, 54);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 228);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(141, 54);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(129, 228);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(277, 54);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(129, 228);
            this.listBox3.TabIndex = 12;
            // 
            // lstClientesAtendidos
            // 
            this.lstClientesAtendidos.FormattingEnabled = true;
            this.lstClientesAtendidos.ItemHeight = 16;
            this.lstClientesAtendidos.Location = new System.Drawing.Point(878, 108);
            this.lstClientesAtendidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstClientesAtendidos.Name = "lstClientesAtendidos";
            this.lstClientesAtendidos.Size = new System.Drawing.Size(153, 292);
            this.lstClientesAtendidos.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnAgregarACola);
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(256, 238);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCajero4);
            this.groupBox2.Controls.Add(this.listBox4);
            this.groupBox2.Controls.Add(this.lblCajero3);
            this.groupBox2.Controls.Add(this.lblCajero2);
            this.groupBox2.Controls.Add(this.lblCajero1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(275, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(551, 302);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CAJEROS (Atencion a clientes)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(474, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Estado: Cerrada";
            // 
            // lblCajero4
            // 
            this.lblCajero4.AutoSize = true;
            this.lblCajero4.BackColor = System.Drawing.Color.Bisque;
            this.lblCajero4.Location = new System.Drawing.Point(425, 34);
            this.lblCajero4.Name = "lblCajero4";
            this.lblCajero4.Size = new System.Drawing.Size(44, 16);
            this.lblCajero4.TabIndex = 13;
            this.lblCajero4.Text = "label5";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(412, 54);
            this.listBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(129, 228);
            this.listBox4.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstClientesAtendidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAbrirSucursal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirSucursal;
        private System.Windows.Forms.Button btnAgregarACola;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCajero1;
        private System.Windows.Forms.Label lblCajero2;
        private System.Windows.Forms.Label lblCajero3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox lstClientesAtendidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCajero4;
        private System.Windows.Forms.ListBox listBox4;
    }
}

