using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
	public partial class frmProfessores : Form
	{
		public frmProfessores()
		{
			InitializeComponent();
		}

		Professores novoProfessor;

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			//Evento do botão Salvar o qual grava as informações através do método Salvar, criado na classe Professor.
			try
			{
				novoProfessor = new Professores();

				if (txtCodigo.Text == "0")
				{
					novoProfessor.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text,
									   	 txtCpf.Text, Convert.ToDecimal(txtSalario,Text), txtTelefone.Text, txtObservacao.Text);
					MessageBox.Show("Professor salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					novoProfessor.Alterar(Convert.ToInt32(txtCodigo.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, txtCpf.Text, txtTelefone.Text, Convert.ToDecimal(txtSalario.Text), txtObservacao.Text);
					MessageBox.Show("Professor alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show (ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void listarProfessores()
		{
			try
			{
				novoProfessor = new Professores();
				dtgProfessores.DataSource = novoProfessor.Listar();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Limpar()
		{
			//Limpa os campos do formulário frmProfessores.
			txtCodigo.Text = "0";
			txtNome.Clear();
			txtEndereco.Clear();
			txtBairro.Clear();
			txtCidade.Clear();
			txtCep.Clear();
			txtCpf.Clear();
			txtTelefone.Clear();
			txtSalario.Clear();
		}

		private void frmProfessores_Load(object sender, EventArgs e)
		{
			//Assim que carregar o formulário, os registros dos professores serão mostrados no DataGridView.
			listarProfessores();
		}

        //Carrega a 'área de cadastro' com os dados da linha selecionada no DataGridView
		private void dtgProfessores_CellCContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//Verifica o nome da coluna que recebe o clique.
			if (dtgProfessores.Columns[e.ColumnIndex].Name == "btnEditar")
			{
				//Atribui a todos os campos o conteúdo das respectivas colunas, referentes a linha selecionada.
				txtCodigo.Text = dtgProfessores.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
				txtNome.Text = dtgProfessores.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
				txtEndereco.Text = dtgProfessores.Rows[e.RowIndex].Cells["ENDERECO"].Value.ToString();
				txtBairro.Text = dtgProfessores.Rows[e.RowIndex].Cells["BAIRRO"].Value.ToString();
				txtCidade.Text = dtgProfessores.Rows[e.RowIndex].Cells["CIDADE"].Value.ToString();
				txtCep.Text = dtgProfessores.Rows[e.RowIndex].Cells["CEP"].Value.ToString();
				txtCpf.Text = dtgProfessores.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
				txtTelefone.Text = dtgProfessores.Rows[e.RowIndex].Cells["TELEFONE"].Value.ToString();
				txtSalario.Text = dtgProfessores.Rows[e.RowIndex].Cells["SALARIO"].Value.ToString();
				txtObservacao.Text = dtgProfessores.Rows[e.RowIndex].Cells["OBSERVACAO"].Value.ToString();
			}
			else if (dtgProfessores.Collections[e.ColumnIndex].Name == "btnExcluir" && 
					MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					novoProfessor = new Professores();
					novoProfessor.Excluir(Convert.ToInt32(dtgProfessores.Rows[e.RowIndex].Cells["CODIGO"].Value));
					MessageBox.Show("Professor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					listarProfessores();
					Limpar();
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		//Evento do botão btnNovo o qual utiliza o método 'Limpar' para limpar todos os campos do frmProfessores.
		private void btnNovo_Click(object sender, EventArgs e)
		{
			Limpar();
		}

		private void txtPesquisa_TextChanget(object sender, EventArgs e)
		{
			/* Evento do txtPesquisa, o qual que verifica se desejamos pesquisar por um nome ou CPF
			 * e exiba os resultados de acordo com o que foi digitado no mesmo.s*/
			novoProfessor = new Professores();
			try
			{
				if (rbNome.Checked)
				{
					dtgProfessores.DataSource = novoProfessor.PesquisarNome(txtPesquisa.Text);
				}
				else
				{
					dtgProfessores.DataSource = novoProfessor.PesquisarCpf(txtPesquisa.Text);
				}
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}