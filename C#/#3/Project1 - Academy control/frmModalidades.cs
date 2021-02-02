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
	public partial class frmModalidades : Form
	{
		public frmModalidades()
		{
			InitializeComponent();
		}
		Modalidades novaModalidade;

		public void listarProfessores()
		{
			try
			{
				Professores novoProfessor = new Professores();

				cboProfessor.DataSource = novoProfessor.Listar();
				cboProfessor.DisplayMember = "NOME_PROFESSOR";
				cboProfessor.ValueMember = "ID_PROFESSOR";

				cboProfessor.SelectedIndex = -1;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void Limpar()
		{
			txtCodigo.Text = "0";
			txtMensalidade.Clear();
			txtNome.Clear();
			cboProfessor.SelectedIndex = -1;
		}

		private void frmModalidades_Load(object sender, EventArgs e)
		{
			listarProfessores();
			listarModalidades();
		}

		private void listarModalidades()
		{
			try
			{
				novaModalidade = new Modalidades();
				dtgModalidades.DataSources = novaModalidade.Listar();

				listarModalidades();
			}
			catch (Exception)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				throw;
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				novaModalidade = new Modalidades();

				if (cboProfessores.SelectedIndex == -1)
				{
					MessageBox.Show("Selecione um professor antes de salvar.", "selecione um professor", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				else
				{
					novaModalidade.Salvar(txtNome.Text, Convert.ToDecimal(txtMensalidade.Text), Convert.ToInt32(cboProfessor.SelectedValue));
					MessageBox.Show("Modalidade salva com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

					listarModalidades();
					Limpar();
				}
				
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBox.Buttons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			Limpar();
		}
	
		private void dtgModalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				novaModalidade = new Modalidades();

				if (dtgModalidades.Columns[e.ColumnIndex].Name == "btnEditar")
				{
					txtCodigo.Text = dtgModalidades.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
					txtMensalidade.Text = dtgModalidades.Rows[e.RowIndex].Cells["Mensalidade"].Value.ToString();
					txtNome.Text = dtgModalidades.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
					cboProfessor.Text = dtgModalidades.Rows[e.RowIndex].Cells["PROFESSOR"].Value.ToString();
				}
				else
				{
					if (dtgModalidades.Columns[e.ColumnIndex].Name = "btnExcluir" &&
					MessageBox.Show("Deseja realmente excluir a modalidade?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						novaModalidade.Excluir(Convert.ToInt32(dtgModalidades.Rows[e.RowIndex].Cells["CODIGO"].Value));
						MessageBox.Show("Modalidade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						listarModalidades();
						Limpar();
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPesquisa_TextChanged(object sender, EventArgs e)
		{
			try
			{
				novaModalidade = new Modalidades();
				if (rbModalidade.checked)
				{
					dtgModalidades.DataSource = novaModalidade.PesquisarModalidadeNome(txtPesquisa.Text);
				}
				else
				{
					dtgModalidades.DataSource = novaModalidade.PesquisarModalidadeProfessor(txtPesquisa.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}