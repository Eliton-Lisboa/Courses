using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoAppCSharp
{
    public abstract class Pessoa //Classe abstrata Pessoa
    {
        public abstract void GravarPessoa(string nome, string endereco, string documento1, string documento2);
    }
}
