using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAlura
{
    class investimento : conta, Itributavel
    {        
        public override void saque(double valor)
        {
            this.saldo -= valor;
        }

        public double CalculaTributo()
        {
            return this.saldo * 0.03;
        }
    }
}
