using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoAppCSharp
{
    public class PessoaJuridica : Pessoa //Classe PessoaJuridica herda a classe Pessoa
    {
        private string cnpj, ie;         //Atributos cnpj e ie

        public PessoaJuridica(string nome, string endereco, string cnpj, string ie)
        {
            base.GravarPessoa(nome, endereco); //O método GravarPessoa da classe base receberá os valores dos parâmetros nome e endereco
            this.cnpj = cnpj; //O atributo cnpj desta classe será igual ao parâmetro com mesmo nome
            this.ie = ie;     //O atributo ie desta classe será igual ao parâmetro com mesmo nome
        }

        public string MostrarCnpj() //Método publico MostrarCnpj
        {
            return cnpj;            //Retorna o valor gravado no atributo cnpj
        }

        public string MostrarIe()   //Método publico MostrarIe
        {
            return ie;              //Retorna o valor gravado no atributo ie
        }
    }
}
