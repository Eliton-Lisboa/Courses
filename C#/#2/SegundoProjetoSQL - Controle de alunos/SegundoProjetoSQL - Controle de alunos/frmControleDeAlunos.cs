using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProjetoSQL___Controle_de_alunos
{
    public partial class frmControleDeAlunos : Form
    {
        public frmControleDeAlunos()
        {
            InitializeComponent();
        }

        private void frmControleDeAlunos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escolaDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.escolaDataSet.Alunos);

        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escolaDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbAluno.Checked)
            {
                dtgPesquisas.DataSource = alunosTableAdapter.RetornarAluno(txbPesquisa.Text);
            }

            else
            {
                dtgPesquisas.DataSource = alunosTableAdapter.RetornarCurso(txbPesquisa.Text);
            }
        }
    }
}
