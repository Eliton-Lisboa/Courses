using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoAppCSharp
{
    public class Pessoa //Classe pessoa
    {
        private string nome, endereco; //Atributos nome e endereco

        public void GravarPessoa(string nome, string endereco) //Método resposável por gravar o nome e endereco
        {
            this.nome = nome; //O atributo nome receberá o texto do parâmetro nome
            this.endereco = endereco; //O atributo endereco receberá o texto do parâmetro endereco
        }

        public string MostrarNome() //Método responsavel por mostrar o texto do atributo nome
        {
            return nome;
        }

        public string MostrarEndereco() //Método responsavel por mostrar o texto do atributo endereco
        {
            return endereco;
        }
    }
}
