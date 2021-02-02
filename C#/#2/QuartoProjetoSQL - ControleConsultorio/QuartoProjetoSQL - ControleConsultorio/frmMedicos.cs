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
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet1);

        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorioDataSet1.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.consultorioDataSet1.Medico);

        }
    }
}
