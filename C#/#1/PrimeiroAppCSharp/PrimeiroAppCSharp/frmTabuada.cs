using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroAppCSharp
{
    public partial class frmTabuada : Form
    {

        public frmTabuada()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Você precisa digitar o número para calcular a tabuada",
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double numero, resultado;
                numero = double.Parse(txtNumero.Text);

                for (int i = 0; i <= 10; i++)
                {
                    resultado = numero * i;
                    txtTabuada.Text += numero + "x" + i + "=" + resultado + "\r\n";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtTabuada.Text = "";
        }
    }
}
