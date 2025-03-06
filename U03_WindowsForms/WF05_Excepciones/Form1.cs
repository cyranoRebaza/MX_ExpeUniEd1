using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF05_Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            try
            {
                num1 = int.Parse(txtUno.Text);
                num2 = int.Parse(txtDos.Text);

                resultado = num1 / num2;

                lblResultado.Text = $"= {resultado}";
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Por favor, cargar solo números...");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero...");

            }
        }
    }
}
