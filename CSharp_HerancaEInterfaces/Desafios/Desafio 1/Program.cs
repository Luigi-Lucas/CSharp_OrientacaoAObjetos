using Desafio_1;

public class Program
{
    public static void Main(string[] args)
    {
        int opc = 0;
        while (opc != 9)
        {
            Console.Clear();
            Console.WriteLine("Digite a Operação que deseja fazer \n1 - Soma \n2 - Subtracao \n3 - Multiplicação \n4 - Divisao \n9 - Finalizar");
            Console.Write("Selecione a opção: ");
            opc = Convert.ToInt16(Console.ReadLine());

            if (opc == 9)
            {
                Console.Clear();
                Console.WriteLine("Programa Finalizado!");
                System.Environment.Exit(0);
            }

            Console.Clear();
            Operacoes operacoes = new Operacoes();
            Console.Write("Digite o Primeiro Valor: ");
            double primeiroValor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o Segundo Valor: ");
            double segundoValor = Convert.ToDouble(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Resultado da Soma: " + operacoes.Soma.Calculo(primeiroValor, segundoValor));
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Resultado da Subtração: " + operacoes.Subtracao.Calculo(primeiroValor, segundoValor));
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Resultado da Multiplicação: " + operacoes.Multiplicacao.Calculo(primeiroValor, segundoValor));
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Resultado da Divisão: " + operacoes.Divisao.Calculo(primeiroValor, segundoValor));
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
    }
}