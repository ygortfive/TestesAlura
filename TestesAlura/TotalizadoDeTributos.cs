using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAlura
{
    class TotalizadoDeTributos
    {
        public double Total { get; private set; }

        public void acumula(Itributavel cp)
        {
            this.Total += cp.CalculaTributo();
        }
    }
}
