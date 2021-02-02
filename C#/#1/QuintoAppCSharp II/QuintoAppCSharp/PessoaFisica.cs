using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoAppCSharp
{
    public class PessoaFisica : Pessoa //Classe PessoaFisica herda a classe abstrata Pessoa
    {
        private string nome, endereco, rg, cpf; //Atributos da PessoaFisica

        //Método para gravar os dados da PessoaFisica, herdado da classe abstrata Pessoa
        public void GravarPessoa(string nome, string endereco, string documento1, string documento2)
        {
            //Adicionando valores aos atributos
            this.nome = nome;
            this.endereco = endereco;
            this.rg = documento1;
            this.cpf = documento2;
        }

        //Métodos para exibir os dados armazenados
        public string MostrarNome()
        {
            return nome;
        }

        public string MostrarEndereco()
        {
            return endereco;
        }

        public string MostrarDocumento1()
        {
            return rg;
        }

        public string MostrarDocumento2()
        {
            return cpf;
        }
    }
}