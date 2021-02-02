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
	public partial class frmTurmas : Form
	{
		public frmTurmas()
		{
			InitializeComponent();
		}
		Turmas novaTurma;
		Horarios novoHorario;
	
		private void dtgTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dtgTurmas.Columns[e.ColumnIndex].Name == "btnEditar")
			{
				txtCodigo.Text = dtgTurmas.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
				txtMensalidade.Text = dtgTurmas.Rows[e.RowIndex].Cells["Mensalidade"].Value.ToString();
				txtNome.Text = dtgTurmas.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
				cboProfessor.Text = dtgTurmas.Rows[e.RowIndex].Cells["PROFESSOR"].Value.ToString();
			}
			else
			{
				if (dtgTurmas.Columns[e.ColumnIndex].Name = "btnExcluir" &&
				    MessageBox.Show("Deseja realmente excluir a modalidade?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					novaTurma.Excluir(Convert.ToInt32(dtgTurmas.Rows[e.RowIndex].Cells["CODIGO"].Value));
					MessageBox.Show("Modalidade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					listarModalidades();
					Limpar();
				}
                else
                {
                    if (dtgTurmas.Columns[e.ColumnIndex].Name == "btnHorario" &&
                        MessageBox.Show("Deseja cadastrar horários para esta turma?", "Deseja cadastrar horários?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmHorarios frm = new frmHorarios(Convert.ToInt32(dtgTurmas.Rows[e.RowIndex].Cells["CODIGO"].Value),
                        dtgTurmas.Rows[e.RowIndex].Cells["MODALIDADE"].Value.ToString(), dtgTurmas.Rows[e.RowIndex].Cells["NUMERO"].Value.ToString());
                        frm.ShowDialog();
                    }
                }
			}
		}

		private void dtgTurmas_DoubleClick(object sender, EventArgs e)
		{
			novoHorario = new Horarios();

			DataTable dadosTabela = new DataTable();
			dadosTabela = novoHorario.Listar(Convert.ToInt32(dtgTurmas.Rows[dtgTurmas.CurrentRow.Index].Cells["CODIGO"].Value));

			if (dadosTabela.Rows.Count <= 0)
			{
				int linhas = dtgExibirHorarios.Rows.Count;

				for (int x = 0; x < linhas; x++)
				{
					dtgExibirHorarios.Rows.Remove(dtgExibirHorarios.Rows[0]);
				}
				lblAviso.Visible = true;
				lblHorarios.Visible = true;
				lblAviso.Text = "Nunhum horário cadastardo";
			}
			else
			{
				lblAviso.Visible = false;
				lblHorarios.Visible = false;

				dtgExibirHorarios.DataSource = dadosTabela;

				int linhas = dtgExibirHorarios.Rows.Count;

				for (int x = 0; x < linhas; x++)
				{
					dtgExibirHorarios.Rows[x].DefaultCellStyle.BackColor = Color.LightSteelBlue;
					x++;
				}
				
			}
		}
	}
}