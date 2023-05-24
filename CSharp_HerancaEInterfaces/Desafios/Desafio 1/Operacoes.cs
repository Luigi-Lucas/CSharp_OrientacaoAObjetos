using Desafio_1.OperacoesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Operacoes
    {
        public Soma Soma { get; set; }
        public Subtracao Subtracao { get; set; }
        public Multiplicacao Multiplicacao { get; set; }
        public Divisao Divisao { get; set; }

        public Operacoes()
        {
            Soma = new Soma();
            Subtracao = new Subtracao();
            Multiplicacao = new Multiplicacao();
            Divisao = new Divisao();
        }
    }
}
