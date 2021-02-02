using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
	public partial class frmAlunos : Form
	{
		public frmAlunos()
		{
			InitializeComponent();
		}
		Alunos novoAluno;
		frmControleAlunos controleAlunos;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controleAlunos = new frmControleAlunos(this);
            controleAlunos.ShowDialog();
        }

		public void ListarAlunos()
		{
			try
			{
				novoAluno = new Alunos();
				dtgAlunos.DataSource = novoAluno.Listar();
				Estilo();
			}
			catch (Exception)
			{
				
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmAlunos_Enter(object sender, EventArgs e)
		{
			ListarAlunos();
		}

		private void dtgAlunos_DoubleClick(object sender, EventArgs e)
		{
			DataGridView alunoSelecionado = dtgAlunos.Rows[dtgAlunos.CurrentRow.Index].DataGridView;
			controleAlunos = new frmControleAlunos(this);
			controleAlunos.ExibirAluno(alunoSelecionado);
			controleAlunos.ShowDialog();
		}
	}
}