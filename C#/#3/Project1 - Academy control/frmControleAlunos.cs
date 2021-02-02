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
	public partial class frmControleAlunos : Form
	{
        frmAlunos formulario;

		public frmControleAlunos(frmAlunos formulario)
		{
			InitializeComponent();
            this.ListarTurmas();
            this.formulario = formulario;
		}
        Alunos novoAluno;
        Turmas novaTurma;

        private void Limpar()
        {
            txtCodigo.Text = "0";
            txtNome.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            cboSexo.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                novoAluno = new Alunos();
                novoAluno.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtCep.Text,
                                 txtCpf.Text, txtTelefone.Text, txtCelular.Text, cboSexo.Text, txtObservacao.Text);
                MessageBox.Show("Aluno salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarUltimoAlunoCadastrado();

                if (MessageBox.Show("Deseja realizar a matrícula do aluno?", "Realizar matrícula?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tcAlunos.SelectedIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Errorr);
            }
        }

        private void ListarUltimoAlunoCadastrado()
        {
            try
            {
                novoAluno = new Alunos();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoAluno.Listar();
                txtCodAluno.Text = dadosTabela.Rows[0]["ID_ALUNO"].ToString();
                txtNomeAluno.Text = dadosTabela.Rows[0]["NOME_ALUNO"].ToString();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Errorr);
            }
        }

        private void ListarTurmas()
        {
            try
            {
                novaTurma = new Turmas();
                dtgTurmasCadastradas.DataSource = novaTurma.Listar();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Errorr);
            }
        }

        public void ExibirAluno(DataGridView aluno)
        {
            try
            {
                this.Text = "SCA - Controle de Alunos :: " + aluno.Rows[aluno.CurrentRow.Index].Cells["NOME_ALUNO"] + " ::";
                txtCodigo.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
                txtNome.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["NOME_ALUNO"].Value.ToString();
                txtEndereco.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["ENDERECO"].Value.ToString();
                txtBairro.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["BAIRRO"].Value.ToString();
                txtCidade.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CIDADE"].Value.ToString();
                txtCep.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CEP"].Value.ToString();
                txtCpf.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CPF"].Value.ToString();
                txtTelefone.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["TELEFONE"].Value.ToString();
                txtCelular.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CELULAR"].Value.ToString();
                cboSexo.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["SEXO"].Value.ToString();
                txtObservacao.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["OBSERVACAO"].Value.ToString();

                txtCodAluno.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["CODIGO"].Value.ToString();
                txtNomeAluno.Text = aluno.Rows[aluno.CurrentRow.Index].Cells["NOME_ALUNO"].Value.ToString();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmControleAlunos_FormClosed(object sender, EventArgs e)
        {
            formulario.ListarAlunos();
        }
	}
}