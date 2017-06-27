using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAlura
{
    public abstract class conta
    {
        
            protected string numero { get; set; }
            public double saldo { get; set; }           

            public void mostrar()
            {
                Console.WriteLine("Número da conta: " + this.numero +" \nSaldo: " + this.saldo);
            }

            //Criar um metodo abstract em uma classe abstract obriga as classes filhas terem a mesma classe
            public abstract void saque(double valor);

            //public abstract double CalculaTributo();  
            
            public virtual void deposito(double valor)
            {
                if (valor < 0)
                {
                    Console.WriteLine("Não é permitido realizar depositos com valores menores que zero");
                }
                else
                {
                    this.saldo += valor;                    
                }
            }
        
    
    }
}
