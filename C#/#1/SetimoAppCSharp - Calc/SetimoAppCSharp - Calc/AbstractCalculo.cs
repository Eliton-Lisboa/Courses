using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetimoAppCSharp___Calc
{
    public abstract class AbstractCalculo
    {
        // Propriedades Autoimplementadas abstratas
        public abstract double valorVisor { set; get; }
        public abstract double valorAnterior { set; get; }
        public abstract double valorResultado { set; get; }
        public abstract string operacao { set; get; }

        public abstract double Calculo(); // Método abstrato do tipo double
    }
}
