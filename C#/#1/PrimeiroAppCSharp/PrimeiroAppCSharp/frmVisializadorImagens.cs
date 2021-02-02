using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroAppCSharp
{
    public partial class frmVisializadorImagens : Form
    {
        public frmVisializadorImagens()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStretch.Checked == true)
            {
                pbImagens.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnMostrarImagem_Click(object sender, EventArgs e)
        {
            if (ofdImagens.ShowDialog() == DialogResult.OK)
            {
                pbImagens.Load(ofdImagens.FileName);
                btnMostrarImagem.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmVisializadorImagens_Load(object sender, EventArgs e)
        {

        }

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            pbImagens.Image = null;
            btnMostrarImagem.Enabled = true;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked == true)
            {
                pbImagens.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
