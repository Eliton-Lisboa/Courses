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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarMensagem_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Primeiro Aplicativo em C#"; //Define o texto a label.
            lblMensagem.ForeColor = Color.RoyalBlue; //Define lblMensagem(label) como cor azul royal.
            btnPropriedadesCheckBox.Enabled = true;
            btnImagens.Enabled = true;
            btnTabuada.Enabled = true;
        }

        private void btnPropriedadesCheckBox_Click(object sender, EventArgs e)
        {
            frmPropriedadesCheckBox propriedades = new frmPropriedadesCheckBox(); //Intanciando frmpropriedades    }mostrar outra "tabela"
            propriedades.ShowDialog(); //ele exibe o formulario pelo metodo showdialog                             }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
             
        }

        private void btnImagens_Click(object sender, EventArgs e)
        {
            frmVisializadorImagens visializadorImagens = new frmVisializadorImagens();
            visializadorImagens.ShowDialog();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            frmTabuada tabuada = new frmTabuada();
            tabuada.ShowDialog();
        }
    }
}
