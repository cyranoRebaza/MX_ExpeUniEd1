﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF01_intro
{
    public partial class Form1 : Form
    {
        // constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Metodo especial asociado a una accion denominado evento
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola mundo");

            // Capturo el texto de la caja de texto
            string nombre = txtNombre.Text;

            // asigno al lblSaludo el nombre
            lblSaludo.Text = $"Hola {nombre}";
        }

       
    }
}
