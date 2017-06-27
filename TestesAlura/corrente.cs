using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesAlura
{
    class corrente : conta
    {
        public static int totContas { get; private set; } //static quer dizer que pertence a classe, não a algum objeto
        
        public corrente()
        {
        MessageBox.Show("Teste conta corrente");
        corrente.totContas++;
        MessageBox.Show("Proxima conta é: " + corrente.ProximoNum());
        }

        public static int ProximoNum()
        {
            return corrente.totContas + 1;
        }

        //Criar um metodo abstract em uma classe abstract obriga as classes filhas terem a mesma classe
        public override void saque(double valor)
        {
            this.saldo -= valor;
        }
    }
}
