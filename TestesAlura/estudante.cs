using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesAlura
{
    class estudante : conta
    {
        public estudante()
        {
            MessageBox.Show("Teste conta estudante");
        }

        //Criar um metodo abstract em uma classe abstract obriga as classes filhas terem a mesma classe
        public override void saque(double valor)
        {
            this.saldo -= valor;
        }
    }
}
