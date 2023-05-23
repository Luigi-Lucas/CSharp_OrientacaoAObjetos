﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public static int NumeroDeClientes { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
            NumeroDeClientes++;
        }
    }
}
