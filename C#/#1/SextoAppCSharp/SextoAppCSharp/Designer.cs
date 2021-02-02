using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SextoAppCSharp
{
    public class Designer : IFuncionario
    {
        string nome, cargo;
        decimal salario;

        public void Salvar(string nome, string cargo, decimal salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public string retornaNome()
        {
            return nome;
        }

        public string retornaCargo()
        {
            return cargo;
        }

        public decimal retornaSalario()
        {
            return salario;
        }
    }
}
