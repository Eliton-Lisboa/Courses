using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuartoProjetoSQL___ControleConsultorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            //evento Click do btnMedicos em que o formulário frmMedicos é instanciado e exibido
            frmMedicos novoMedico = new frmMedicos();
            novoMedico.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas novaConsulta = new frmConsultas();
            novaConsulta.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes novoPaciente = new frmPacientes();
            novoPaciente.ShowDialog();
        }
    }
}
