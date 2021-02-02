using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuintoAppCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Evento click do botão pessoa física
        {
            pnlPessoaFisica.Visible = true; //Deixa Vísivel do painel destinado á pessoa física
            pnlPessoaJuridica.Visible = false; //Deixa Invisível o painel destinado á pessoa Jurídica
        }

        private void button2_Click(object sender, EventArgs e) //Evento click do botão pessoa jurídica
        {
            pnlPessoaFisica.Visible = false; //Deixa Invísivel do painel destinado á pessoa física
            pnlPessoaJuridica.Visible = true; //Deixa Visível o painel destinado á pessoa Jurídica
        }

        private void btnSalvar_Click(object sender, EventArgs e) //Evento Click do botão Salvar
        {
            if (pnlPessoaFisica.Visible == true) //Se o painel destinado à Pessoa Físicaestiver visível
            {
                PessoaFisica novaPessoaFisica = new PessoaFisica(); //Instranciar a classe PessoaFisica para utilizá-la

                //Gravar os textos digitados em cada campo do painel Pessoa Física para seus respectivos stributos
                novaPessoaFisica.GravarPessoa(txtNomePessoaFisica.Text, txtEnderecoPessoaFisica.Text, txtRg.Text, txtCpf.Text);

                //Exibir os dados gravados no componente txtMostrarPessoaFisica com tabulação
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarNome() + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarEndereco() + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarRg() + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.MostrarCpf() + "\n");
                Limpar(); //Executa o método Limpar
            }
            else //Senão
            {
                PessoaJuridica novaPessoaJuridica = new PessoaJuridica(txtNomePessoaJuridica.Text, txtEnderecoPessoaJuridica.Text, txtCnpj.Text, txtIe.Text); //Instanciar a classe PessoaJuridica

                //Exibir os dados gravaods no componente txtMostrarPessoaJuridica com tabulação
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarNome() + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarEndereco() + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarCnpj() + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJuridica.MostrarIe() + "\n");
                Limpar(); //Executa o método Limpar
            }
        }

        public void Limpar()    //Método limpar
        {
            if (pnlPessoaFisica.Visible == true)  //Se o painel Pessoa Fisíca tiver visível
            {
                txtNomePessoaFisica.Text = "";      //Deixa a propriedade Text do objeto que recebe o Nome igual a vazio
                txtEnderecoPessoaFisica.Text = "";  //Deixa a propriedade Text do objeto que recebe o Endereço igual a vazio
                txtRg.Text = "";                    //Deixa a propriedade Text do objeto que recebe o Rg igual a vazio
                txtCpf.Text = "";                   //Deixa a propriedade Text do objeto que recebe o Cpf igual a vazil
            }
            else //Senão
            {
                txtNomePessoaJuridica.Text = "";      //Deixa a propriedade Text do objeto que recebe o Nome igual a vazio
                txtEnderecoPessoaJuridica.Text = "";  //Deixa a propriedade Text do objeto que recebe o Endereço igual a vazio
                txtCnpj.Text = "";                    //Deixa a propriedade Text do objeto que recebe o Cnpj igual a vazio
                txtIe.Text = "";                   //Deixa a propriedade Text do objeto que recebe o Ie igual a vazil
            }
        }
    }
}
