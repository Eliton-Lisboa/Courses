using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoAppCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Variáveis responsáveis por receber as notas calculadas com o peso.
            double Nota1, Nota2, Trabalho;

            //Converte o conteúdo dos componentes TextBox e ComboBox para double e realiza a multiplicação dos mesmes.
            Nota1 = Convert.ToDouble(txtNota1.Text) * Convert.ToDouble(cboPesoNota1.Text);
            Nota2 = double.Parse(txtNota2.Text) * double.Parse(cboPesoNota2.Text);
            Trabalho = Convert.ToDouble(txtTrabalho.Text) * Convert.ToDouble(cboPesoTrabalho.Text);

            // Soma das variáveis para que se obtenha a média.
            double Media = Nota1 + Nota2 + Trabalho;

            txtMediaFinal.Text = Media.ToString(); // Convertendo e atribuindo a variável Media para o txtMediaFinal

            // Variáveis responsaveis por receber as quantidades de aulas e faltas.
            double QdeAulas, QdeFaltas;

            // Converte o conteúdo dos conponentes TextBox(QdeAulas e QdeFaltas)
            QdeAulas = Convert.ToDouble(txtQdeAulas.Text);
            QdeFaltas = Convert.ToDouble(txtQdeFaltas.Text);

            // Realiza a conta necessária para se achar a porcentagem de presença do aluno
            double PorcentagemPresenca = 100 - ((QdeFaltas / QdeAulas) * 100);

            // Realiza a conta do aproveitamento do aluno e converte o valor em string para ser exibido no txtAproveitamento
            txtAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) / 2) + "%";

            if (txtRecuperacao.Text == "")
            {
                if (Media >= Convert.ToDouble(numNotaCorte.Value) && PorcentagemPresenca >= 75)
                {
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                }

                    // Caso o if anterior retornar falso, será verificado se a média obtida é menor que 2,5
                //OU se a prosença for inferior a 75%
                else
                    if(Media <= 2.5 || PorcentagemPresenca < 75)
                    {
                        //No caso do Else if retornar verdade:
                        lblSituacao.Text = "Reprovado"; //irá aparecer Reprovado no campo lblSituação.Text,
                        lblSituacao.ForeColor = Color.Firebrick; // com a cor Firebrick(vermelho).
                    }

                   //No caso de o if e o Else if retornarem falsos, obrigatóriamente a execução irá passar por este Else  
                    else
                    {
                        lblSituacao.Text = "Recuperação"; //irá aparecer Recuperação no campo lblSituacao.Text,
                        lblSituacao.ForeColor = Color.Firebrick; //Com a cor Firebrick(vermelho).
                    }
            }

                //No caso do campo lblRecuperacao possuir conteúdo, a execução do programa sera desviada para esse Else
            else
            {
                //Cálculo da nova média, somando-a ela mesma como conteúdo do componente txtRecuperacao.Text e dividido por 
                Media = (Media + Convert.ToDouble(txtRecuperacao.Text)) / 2;

                //Atribuição do novo cálculo sobre o aproveitamento do aluno para o campo txtAproveitamento
                txtAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) / 2) + "%";

                //A partir da nova média é verificado se aluno atingio nota igual o superior a 5
                if (Media >= 5)
                {
                    //Se a condição retornar verdade, então:
                    lblSituacao.Text = "Aprovado"; // irá aparecer aprovado no campo lblSituação.Text,
                    lblSituacao.ForeColor = Color.Green; // com a cor verde.
                }

                    //Caso o if acima retornar falso, será executado as instruções que estão dentro do Else abaixo.
                else
                {
                    lblSituacao.Text = "Reprovado"; //Irá aparecer Reprovado no campo lblSituação.Text,
                    lblSituacao.ForeColor = Color.Firebrick;// com a cor Firebrick(vermelho).
                }

                txtMediaFinal.Text = Media.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSituacao.Text = "";
            txtRecuperacao.Text = string.Empty;

            //Laço de repetição que irá percorrer todos os componentes do formulário.
            foreach(Control Componente in this.Controls)
            {
                if (Componente is TextBox)
                {
                    (Componente as TextBox).Clear();
                }

                else
                    if (Componente is ComboBox)
                    {
                        (Componente as ComboBox).SelectedIndex = -1;
                    }
                    else
                        if (Componente is NumericUpDown)
                        {
                            (Componente as NumericUpDown).Value = 5;
                        }
            }
        }
    }
}
