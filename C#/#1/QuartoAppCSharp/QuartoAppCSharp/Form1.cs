using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuartoAppCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Veiculo //classe veiculo
        {
            public string modelo, placa, Km; //atributos do veiculo

            //---- métodos atribiidores de valores do objeto ----------------
            public void gravaModelo(string modelo)
            {
                this.modelo = modelo; // adicionando o valor ao atributo
            }

            public void gravarPlaca(string placa)
            {
                this.placa = placa; // adicionando o valor ao atributo
            }

            public void gravarKm(string Km)
            {
                this.Km = Km; // adicionando o valor ao atributo
            }
            //--------------------------------------------------


            // ---- métodos que leêm os atributos do objeto ----
            public string mostrarModelo()
            {
                return modelo; //retorna o vaor do atribudo
            }

            public string mostrarPlaca()
            {
                return placa; //retorna o vaor do atribudo
            }

            public string mostrarKm()
            {
                return Km; //retorna o vaor do atribudo
            }

            public string propriedadesModelo
            {
                set { modelo = value; }
                get { return modelo; }
            }
            public string propriedadePlaca
            {
                set { placa = value; }
                get { return placa; }
            }
            public string propriedadeKm
            {
                set { Km = value; }
                get { return Km; }
            }
        }

        private void button3_Click(object sender, EventArgs e) // evento click do botão btnSalvar
        {
            if (txtEixo.Visible == false)
            {
                Veiculo novoCarro = new Veiculo(); //Instanciando um objeto do tipo veiculo

                /* novoCarro.gravaModelo(txtModelo.Text); //gravar o texto que escrever dentro do txtModelo
                novoCarro.gravarPlaca(txtPlaca.Text); //gravar o texto que escrever dentro do txtPlaca
                novoCarro.gravarKm(txtKm.Text); //gravar o texto que escrever dentro do txtKm

                txtCarros.Text += novoCarro.mostrarModelo() + "\t"; //mostra o modelo no txtCarros
                txtCarros.Text += novoCarro.mostrarPlaca() + "\t"; //mostra a placa no txtCarros
                txtCarros.Text += novoCarro.mostrarKm() + "\r\n"; //mostra a Kilometragem no txtCarros */

                novoCarro.propriedadesModelo = txtModelo.Text;
                novoCarro.propriedadePlaca = txtPlaca.Text;
                novoCarro.propriedadeKm = txtKm.Text;

                txtCarros.AppendText(novoCarro.propriedadesModelo + "\t");
                txtCarros.AppendText(novoCarro.propriedadePlaca + "\t");
                txtCarros.AppendText(novoCarro.propriedadeKm + "\n");
            }

            else
            {
                Caminhao novocaminhao = new Caminhao();

                novocaminhao.propriedadesModelo = txtModelo.Text;
                novocaminhao.propriedadePlaca = txtPlaca.Text;
                novocaminhao.propriedadeKm = txtKm.Text;
                novocaminhao.propriedadeEixo = txtEixo.Text;

                txtCaminhoes.AppendText(novocaminhao.propriedadesModelo + "\t");
                txtCaminhoes.AppendText(novocaminhao.propriedadePlaca + "\t");
                txtCaminhoes.AppendText(novocaminhao.propriedadeKm + "\t");
                txtCaminhoes.AppendText(novocaminhao.propriedadeEixo + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblEixo.Visible = true;
            txtEixo.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e) // evento click do botao btnCarros
        {
            lblEixo.Visible = false; // transforma em "invisível" o componente lblEixo
            txtEixo.Visible = false; // transforma em "invisível" o componente txtEixo
        }

        public class Caminhao : Veiculo
        {
            public string propriedadeEixo { set; get; }
        }
    }
}
