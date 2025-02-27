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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // validar ventantas abiertas recorriendo la coleccion Application.OpenForms
            foreach (var item in Application.OpenForms)
            {
                // si el tipo de objeto que evaluo es igual al tipo form1
                if (item.GetType() == typeof(Form1))
                {
                    return;
                }
            }

            // creo la instancia objeto form1
            Form1 ventana = new Form1();

            // usar ventanas contenedoras
            ventana.MdiParent = this; // ventana donde estoy parado
            ventana.Show();

            // pido que la ventana se muestre
            //ventana.Show(); // genera varias instancia --> varios perfiles
            //ventana.ShowDialog(); // muestra ventana formato de dialogo, captura el momento
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            // como ejemplo uso boton instancio el mismo form1
            Form1 ventana = new Form1();
           
            ventana.ShowDialog();
        }
    }
}
