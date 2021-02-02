using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SextoAppCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cboCargo.Text == "Assistente Administrativo")
            {
                Administrativo funcionario = new Administrativo();
                
                funcionario.Salvar(txtNome.Text, cboCargo.Text, Convert.ToDecimal(txtSalario.Text));

                txtFuncionarios.AppendText(funcionario.retornaNome() + "\t");
                txtFuncionarios.AppendText(funcionario.retornaCargo() + "\t");
                txtFuncionarios.AppendText(funcionario.retornaSalario() + "\n");
            }
            else
            {
                Designer funcionario = new Designer();

                funcionario.Salvar(txtNome.Text, cboCargo.Text, Convert.ToDecimal(txtSalario.Text));

                txtFuncionarios.AppendText(funcionario.retornaNome() + "\t");
                txtFuncionarios.AppendText(funcionario.retornaCargo() + "\t");
                txtFuncionarios.AppendText(funcionario.retornaSalario() + "\n");
            }
        }
    }
}
