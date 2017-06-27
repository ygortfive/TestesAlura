using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAlura
{
    class cliente
    {
        public int idade { get; set; }
        public bool EEmancipado { get; set; }
        public string cpf { get; set; }

        public bool PodeAbrirConta()
        {
            //Quando o tipo for obvio por causa do conteudo do lado direito, podemos declarar como var
            var maiorIdade = (this.idade >= 18);
            var emancipado = (this.EEmancipado);
            //string.IsNullOrEmpty significa que fara o teste se a variavel entre () é nula ou vazia
            // usando o ! podemos verificar se ela não é nula e não é vazia.
            bool temCpf = !string.IsNullOrEmpty(this.cpf);

            //se for maior de idade ou emancipado e tiver cpf, ta limpo !
            return (maiorIdade || emancipado) && temCpf;

        }
    }
}
