using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF02_controlesTernario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // capturar
            string elem = txtNombre.Text;

            // agrego cada elemento al listado
            lwElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agregar al combobox color favorito algunos items
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            // capturamos en nombre
            string nombre = txtNombre.Text;

            // capturamos la fecha nacimiento
            DateTime fecha = dtpFechaNacimiento.Value;

            // verificamos checkbox usando operador ternario
            string chocololate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";

            // verificar el tipo 
            string tipo;
            if (rbtMuggle.Checked)
            {
                tipo = "Muggle";
            }
            else if (rbtWizard.Checked)
            {
                tipo = "Wizard";
            }
            else
            {
                tipo = "Squibs";
            }

            // capturamos el color favorito
            string colorFavorito = cboColorFavorito.SelectedItem.ToString();

            // capturamos el numero favorito
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            // muestro perfil
            MessageBox.Show($" Nombre: {nombre} \n Fecha: {fecha} \n {chocololate} \n Tipo: {tipo} \n color Favorito: {colorFavorito} \n Numero favorito: {numeroFavorito}" );
        }
    }
}
