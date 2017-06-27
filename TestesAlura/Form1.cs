using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesAlura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_teste_Click(object sender, EventArgs e)
        {
            conta[] TesteContas = new conta[3];
            TesteContas[0] = new corrente();
            TesteContas[1] = new poupanca();
            TesteContas[2] = new estudante();

            TesteContas[0].deposito(100);
            TesteContas[1].deposito(500);
            TesteContas[2].deposito(40);

            foreach (conta i in TesteContas)
            {
                MessageBox.Show("O saldo da conta é " + i.saldo);
            }
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            //Quando o tipo for obvio por causa do conteudo do lado direito, podemos declarar como var
            var bob = new cliente();

            if (bob.PodeAbrirConta())
            {
                MessageBox.Show("Pode abrir");
            }
            else
            {
                MessageBox.Show("Não pode");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            corrente contaCorrente = new corrente();
            poupanca contaPoupanca = new poupanca();

            contaCorrente.deposito(100);
            contaPoupanca.deposito(100);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            poupanca cp = new poupanca();
            investimento ci = new investimento();

            cp.deposito(10);
            ci.deposito(100);

            TotalizadoDeTributos t = new TotalizadoDeTributos();
            t.acumula(cp);
            t.acumula(ci);          

            MessageBox.Show("Tributos: " + t.Total);
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            corrente c = new corrente();

        }
    }
}
