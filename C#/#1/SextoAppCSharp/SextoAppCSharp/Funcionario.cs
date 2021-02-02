using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SextoAppCSharp
{
    public abstract class Funcionario
    {
        public abstract void Salvar(string nome, string cargo, decimal salario);

        public abstract string retornaNome();

        public abstract string retornaCargo();

        public abstract decimal retornaSalario();
    }
}
