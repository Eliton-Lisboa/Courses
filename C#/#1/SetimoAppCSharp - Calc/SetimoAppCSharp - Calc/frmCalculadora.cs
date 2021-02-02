using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetimoAppCSharp___Calc
{
    public partial class frmCalculadora : Form
    {
        double valorVisor = 0, valorAnterior = 0;
        string operacao = "";
        bool primeiraOperacao = true, botaoIgual = false;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void ClicouBotao_Click(object sender, EventArgs e) //Evento Click dos botões
        {
            if (txtVisor.Text == "0" || botaoIgual == true) //Se o visor estiver com o numero 0 ou botaoIgual estiver como true
            {
                txtVisor.Clear();     //É para limpá-lo
                botaoIgual = false; //e deixa a variavel botaoIgual como false
            }

            Button botaoAcionado = (Button)sender; //O objeto botão que foi clicado será carregado no botaoAcionado

            switch (botaoAcionado.Name) //Verifica o nome do botão acionado
            {
                case "btn1":                    //caso seja btn1
                    txtVisor.Text += "1";       //A propriedade Text do visor receberá o número 1
                    break;                      //Parar a verificação

                case "btn2":                    //Os próximos casos verificam qual foi o botão adicionado e envia para a
                    txtVisor.Text += "2";       //propriedade Text do mesmo, o número relacionado a ele.
                    break;                      //Após a detecção de qual botão foi acionado, a verificação é finalizada

                case "btn3":
                    txtVisor.Text += "3";
                    break;

                case "btn4":
                    txtVisor.Text += "4";
                    break;

                case "btn5":
                    txtVisor.Text += "5";
                    break;

                case "btn6":
                    txtVisor.Text += "6";
                    break;

                case "btn7":
                    txtVisor.Text += "7";
                    break;

                case "btn8":
                    txtVisor.Text += "8";
                    break;

                case "btn9":
                    txtVisor.Text += "9";
                    break;

                case "btn0":
                    txtVisor.Text += "0";
                    break;

                case "btnVirgula":
                    if (txtVisor.Text == "")
                    {
                        txtVisor.Text += "0,";
                    }
                    else
                    {
                        txtVisor.Text += ",";
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e) //Botão responsável por realizar somas
        {
            if (primeiraOperacao) //Se for a primeira operalção realizada
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valorAnterior passa a ser o que estiver no txtVisor

                if (botaoIgual == false) //Se o botaoIgual estiver como false
                {
                    txtHistorico.Text += txtVisor.Text; //o txtHistorico adiciona o que estiver no txtVisor
                }

                txtVisor.Clear(); //limpa o txtVisor
                operacao = "+"; //determina que a operação realizada é adição
                primeiraOperacao = false; //primeiraOperação passa a ser false
            }
            else //senão
            {
                valorVisor = Convert.ToDouble(txtVisor.Text); //converte o numero do txtVisor para double

                txtHistorico.Text += operacao + txtVisor.Text; //o txtHistorico recebe a operação realizada anteriormente e o número do

                //txtVisor.Text = Convert.ToString(valorAnterior + valorVisor); //realiza a soma dos números e exibe no txtVisor
                //txtVisor.Text = Convert.ToString(Calculo()); //realiza a soma dos numeros e exibe no txtVisor


                ObjetoCalculo novoCalculo = new ObjetoCalculo(); //instância a classe e cria o objeto novoCalculo

                //atribui os valores das variáveis globais às propriedades do objeto novoCalculo
                novoCalculo.valorVisor = this.valorVisor;
                novoCalculo.valorAnterior = this.valorAnterior;
                novoCalculo.operacao = this.operacao;

                //'chama' o método Calculo do objeto novoCalculo e atribui o valor retorno ao txtVisor.Text
                txtVisor.Text = Convert.ToString(novoCalculo.Calculo());

                operacao = "+"; //determina que a última operação realizada é adição
                txtHistorico.Text += "=" + txtVisor.Text; //txtHistorico recebe o sinal de = e o último numero inserido no txtVisor
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passar a ser o que estiver o txtVisor
                botaoIgual = true; //a váriavel botaoIgual passa a ser true
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = "/";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                txtVisor.Text = Convert.ToString(valorAnterior / valorVisor);

                operacao = "/";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = "-";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                txtVisor.Text = Convert.ToString(valorAnterior - valorVisor);

                operacao = "-";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = "x";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                txtVisor.Text = Convert.ToString(valorAnterior * valorVisor);

                operacao = "x";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valorVisor = Convert.ToDouble(txtVisor.Text);

            txtHistorico.Text += operacao + txtVisor.Text;

            //txtVisor.Text = Convert.ToString(Calculo());
            ObjetoCalculo novoCalculo = new ObjetoCalculo(); //instância a classe e cria o objeto novoCalculo

            novoCalculo.valorVisor = this.valorVisor;
            novoCalculo.valorAnterior = this.valorAnterior;
            novoCalculo.operacao = this.operacao;

            txtVisor.Text = Convert.ToString(novoCalculo.Calculo());

            txtHistorico.Text += "=" + txtVisor.Text;

            valorAnterior = Convert.ToDouble(txtVisor.Text);

            botaoIgual = true;
            primeiraOperacao = true;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                operacao = "√";
            }

            valorVisor = Convert.ToDouble(txtVisor.Text);
            txtHistorico.Text += operacao + txtVisor.Text;

            ObjetoCalculo novoCalculo = new ObjetoCalculo();

            novoCalculo.valorVisor = this.valorVisor;
            novoCalculo.valorAnterior = this.valorAnterior;
            novoCalculo.operacao = this.operacao;

            txtVisor.Text = Convert.ToString(novoCalculo.Calculo());

            operacao = "√";
            txtHistorico.Text += "=" + txtVisor.Text;
            valorAnterior = Convert.ToDouble(txtVisor.Text);

            if (novoCalculo.operacao != "√")
            {
                txtHistorico.Text += "=" + operacao + txtVisor.Text;

                valorVisor = Convert.ToDouble(txtVisor.Text);

                novoCalculo.operacao = this.operacao;
                novoCalculo.valorVisor = this.valorVisor;

                txtVisor.Text = Convert.ToString(novoCalculo.Calculo());

                txtHistorico.Text += "=" + txtVisor.Text;
            }
        }

        /* Aula Passada(Método Calculo) - clique no '+' para visualizar o código
        public double Calculo() //método para verificar qual operação deverá ser realizada
        {
            switch (operacao)
            {
                case "+":
                    valorAnterior = valorAnterior + valorVisor;
                    break;

                case "-":
                    valorAnterior = valorAnterior - valorVisor;
                    break;

                case "x":
                    valorAnterior = valorAnterior * valorVisor;
                    break;

                case "/":
                    valorAnterior = valorAnterior / valorVisor;
                    break;

                default:
                    break;
            }

            return valorAnterior;
        }
        */

        private void btnLimpar_Click(object sender, EventArgs e) //Botão reponsável por limpar os campos e atributos, "resetando" as configurações da calculadora
        {
            txtVisor.Clear();
            txtHistorico.Clear();
            valorAnterior = 0;
            valorVisor = 0;

            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;
        }

        private void btnBackSpace_Click(object sender, EventArgs e) //Botão responsável por apagar o último número
        {
            txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
        }
    }
}
