using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    public class Aluno
    {
        private int matricula;
        public int Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    matricula = value;
                }
            }
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }
    }
}
