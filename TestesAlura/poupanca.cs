using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesAlura
{
    class poupanca : conta, Itributavel
    {
        public poupanca()
        {
            MessageBox.Show("Teste conta poupança");
        }

        //Criar um metodo abstract em uma classe abstract obriga as classes filhas terem a mesma classe
        public override void saque(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor Inválido!");
            }
            else if (valor <= this.saldo)
            {
                this.saldo -= valor;
                Console.WriteLine("Saque realizado!");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
        }

        public double CalculaTributo()
        {
            return this.saldo * 0.02;
        }
    }
}
