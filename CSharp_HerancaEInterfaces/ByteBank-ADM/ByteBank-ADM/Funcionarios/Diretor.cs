using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)/* utilizando o comando base no construtor, é passado como
                                                                        * parâmetro a informação que chega na classe filha (Diretor)
                                                                        * para a superclasse (Funcionário). */
        {

        }
        public double GetBonificacao() //override é um conceito que permite que um método da superclasse seja reescrito.
        {
            return Salario * 1.10;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
