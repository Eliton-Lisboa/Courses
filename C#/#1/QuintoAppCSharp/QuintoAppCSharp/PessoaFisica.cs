using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoAppCSharp
{
    public class PessoaFisica : Pessoa //Classe PessoaFisica herda a classe Pessoa
    {
        private string rg, cpf;      //Atributos rg e cpf

        //Método responsável por gravar o nome, endereco, RG e CPF
        public void GravarPessoa(string nome, string endereco, string rg, string cpf)
        {
            base.GravarPessoa(nome, endereco); //O método GravarPessoa da classe base receberá os valores dos parâmetros nome e endereco
            this.rg = rg; //O atributo rg desta classe será igual ao parâmetro com mesmo nome
            this.cpf = cpf; //O atributo cpf desta classe será igual ao parâmetro com mesmo nome
        }

        public string MostrarRg() //Método publico MostrarRg
        {
            return rg; //Retorna o valor gravado no atributo rg
        }

        public string MostrarCpf() //Método publico MostrarCpf
        {
            return cpf; //Retorna o valor gravado no atributo cpf
        }
    }
}
