using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.OperacoesBasicas
{
    public class Divisao
    {
        public double Calculo(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Impossível dividir por 0");
                return 0;
            }
            else
            {
                return dividendo / divisor;
            }
        }
    }
}
