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
	public partial class frmHorarios : Form
	{
        Horarios novoHorario;

        private int codigo;
        private string modalidade, turma;

		public frmHorarios(int codigo, string modalidade, string turma)
		{
			InitializeComponent();
            this.codigo = codigo;
            this.modalidade = modalidade;
            this.turma = turma;
		}

        private void frmHorarios_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = modalidade + " - Turma: " + turma;
                ListarHorarios();
                cboDia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                novoHorario = new Horarios();

                if (MessageBox.Show("Deseja realmente excluír este horario?", "Deseja excluír?", MessageBox.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    novoHorario.Excluir(Convert.ToInt32(dtgHorarios.Rows[e.RowIndex].Cells["CODIGO_HORARIO"]), ); //Incompleto
                    MessageBox.Show("Horário excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    ListarHorarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarHorarios()
        {
            try
            {
                novoHorario = new Horarios;
                dtgHorarios.DataSource = novoHorario.Listar(codigo);
                Estilo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cboDia.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um dia da semana", "Operação invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclation);
            }
            else
            {
                try
                {
                    novoHorario = new Horarios();

                    if (idHorario == 0)
                    {
                        novoHorario.Salvar(codigo, cboDia.Text, dtpInicio.Value, dtpFim.Value);
                        MessageBox.Show("Horário adicionado com sucesso", "Sucesso", MessageBox.OK, MessageBoxIcon.Information);
                        Limpar();
                        ListarHorarios();
                    }
                    else
                    {
                        novoHorario.Alterar(idHorario, codigo, cboDia.Text, dtpInicio.Value, dtpFim.Value);
                        MessageBox.Show("Horário alterado com sucesso", "Sucesso", MessageBox.OK, MessageBoxIcon.Information);
                        Limpar();
                        ListarHorarios();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBox.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Estilo()
        {
            int linhas = dtgHorarios.Rows.Count;
            for (int x = 0; x < linhas; x++)
            {
                dtgHorarios.Rows[x].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                x++;
            }
        }
    }
}