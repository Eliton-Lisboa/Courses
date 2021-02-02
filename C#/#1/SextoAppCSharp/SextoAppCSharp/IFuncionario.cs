using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SextoAppCSharp
{
    public interface IFuncionario
    {
        void Salvar(string nome, string cargo, decimal salario);

        string retornaNome();
        string retornaCargo();
        decimal retornaSalario();
    }
}
