using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjetoSQL___Consultorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorio.Consultas' table. You can move, or remove it, as needed.
            this.consultasTableAdapter.Fill(this.consultorio.Consultas);
            // TODO: This line of code loads data into the 'consultorio._Consultorio' table. You can move, or remove it, as needed.
            this.consultasTableAdapter.Fill(this.consultorio.Consultas);

        }

        private void consultorioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorio);

        }

        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorio);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            /* evento do botão pesquisar , o qual traz os registros de acordo com a radiobutton selecionado
              * e para isso é necessário indicar que a fonte desses dados é o respectivo método criado no Table Adapter*/
            if (rbMedico.Checked == true)
            {
                dtgPesquisa.DataSource = consultasTableAdapter.RetornarMedico(txtPesquisar.Text);
            }
            else
            {
                dtgPesquisa.DataSource = consultasTableAdapter.RetornarPaciente(txtPesquisar.Text);
            }
        }
    }
}
