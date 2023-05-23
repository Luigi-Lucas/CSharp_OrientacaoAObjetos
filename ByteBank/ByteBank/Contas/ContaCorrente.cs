using ByteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public int NumeroAgencia { get; private set; }
        public string Conta { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }
        public static int TotalDeContas { get; private set; }
        
        public ContaCorrente(string numeroConta, int numeroAgencia, Cliente titular)
        {
            Conta = numeroConta;
            NumeroAgencia = numeroAgencia;
            Titular = titular;
            TotalDeContas++;
        }

        public void depositarValor(double valor)
        {
            Saldo += valor;
        }

        public void sacarValor(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
            else
            {
                Saldo -= valor;
            }
        }

        public void transferirValor(double valor, ContaCorrente destino)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
            else
            {
                sacarValor(valor);
                destino.depositarValor(valor);
                Console.WriteLine($"Transferência de R${valor} para {destino.Titular.Nome} realizada com sucesso!");
            }
        }

        public void exibirInformacoes()
        {
            Console.WriteLine("Titular: " + Titular.Nome +
                "\nNúmero da Agência: " + NumeroAgencia +
                "\nNúmero da Conta: " + Conta +
                "\nSaldo: R$" + Saldo);
        }
    }
}
