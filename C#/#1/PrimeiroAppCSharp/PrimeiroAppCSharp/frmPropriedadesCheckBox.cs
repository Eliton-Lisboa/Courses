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
    public partial class frmPropriedadesCheckBox : Form
    {
        public frmPropriedadesCheckBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkPessoaFisica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoaFisica.Checked == true)
            {
                pnlPessoaFisica.Visible = true;
            }
            else
            {
                pnlPessoaFisica.Visible = false;
            }
        }

        private void chkPessoaJuridica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoaJuridica.Checked == true)
            {
                pnlPessoaJuridica.Visible = true;
            }
            else
            {
                pnlPessoaJuridica.Visible = false;
            }
        }

        private void frmPropriedadesCheckBox_Load(object sender, EventArgs e)
        {

        }
    }
}
