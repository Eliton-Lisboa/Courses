using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SextoAppCSharp
{
    public class Administrativo : Funcionario
    {
        private string nome, cargo;
        private decimal salario;

        public override void Salvar(string nome, string cargo, decimal salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public override string retornaNome()
        {
            return nome;
        }

        public override string retornaCargo()
        {
            return cargo;
        }

        public override decimal retornaSalario()
        {
            return salario;
        }
    }
}
