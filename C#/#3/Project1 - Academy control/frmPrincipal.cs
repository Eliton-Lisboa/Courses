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
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void btnProfessores_Load(object sender, EventArgs e)
		{
			//Evento Click do btnProfessores onde o formulário frmProfessores é instanciado e exibido.
			frmProfessores professor = new frmProfessores();
			VerificaFormulario(professor);
		}

		private void btnModalidades_Click(object sender, EventArgs e)
		{
			//Evento Click do btnModalidades em que o formulário frmModalidades é instanciado e exibido.
			frmModalidades modalidade = new frmModalidades();
			VerificaFormulario(modalidade);
		}

		private void VerificaFormulario(Form novoForm)
		{

			foreach (Form formularios in this.MdiChildren)
			{
				if (formularios.Name == novoForm.Name)
				{
					formularios.Focus();
					return;
				}
			}
			this.LayoutMdi(MdiLayout.Cascade);
			novoForm.MdiParent = this;
			novoForm.Show();
		}
	}
}