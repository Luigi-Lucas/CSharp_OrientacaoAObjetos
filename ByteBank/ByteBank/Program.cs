using ByteBank.Contas;
using ByteBank.Titular;

public class program
{
    public static int i = 0;

    public static void Main()
    {
        ContaCorrente[] vetorContasCorrente = new ContaCorrente[10];
        int opc = 0;
        while (opc != 9)
        {
            Console.Clear();
            Console.WriteLine("     Sistema de Contas Corrente ByteBank");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("1 - Cadastrar uma nova conta \n2 - Realizar um Depósito \n3 - Realizar um Saque \n4 - Visualizar informações de uma conta \n5 - Realizar uma Transferência \n6 - Verificar o número de contas cadastradas \n9 - Finalizar");
            Console.WriteLine("|==========================================|");
            Console.Write("Digite sua opção: ");
            opc = Convert.ToInt16(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Digite o nome do Cliente: ");
                    string ?nome = Console.ReadLine();
                    Console.Write("Digite o número do CPF Cliente: ");
                    string ?cpf = Console.ReadLine();
                    Console.Write("Digite o nome da Profissão do Cliente: ");
                    string ?profissao = Console.ReadLine();

                    Cliente titular = new(nome, cpf, profissao);

                    Console.Write("Digite o número da conta: ");
                    string ?numeroConta = Console.ReadLine();
                    Console.Write("Digite o número da agência: ");
                    int numeroAgencia = Convert.ToInt32(Console.ReadLine());

                    ContaCorrente contaCorrente = new(numeroConta, numeroAgencia, titular);
                    Console.WriteLine("Conta cadastrada com sucesso!");
                    Console.ReadKey();
                    vetorContasCorrente[i] = contaCorrente;
                    i++;
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Digite o número da agência: ");
                    int numAgencia = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o número da conta: ");
                    string ?numConta = (Console.ReadLine());

                    for (int j = 0; j < vetorContasCorrente.Length; j++)
                    {
                        if (vetorContasCorrente[j].NumeroAgencia.Equals(numAgencia) && vetorContasCorrente[j].Conta.Equals(numConta))
                        {
                            Console.Write("Digita o valor que deseja depositar: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            vetorContasCorrente[j].depositarValor(valor);
                            Console.WriteLine($"Deposito de R${valor} realizado com sucesso!");
                            break;
                        }
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Digite o número da agência: ");
                    int nAgencia = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o número da conta: ");
                    string ?nConta = (Console.ReadLine());

                    for (int j = 0; j < vetorContasCorrente.Length; j++)
                    {
                        if (vetorContasCorrente[j].NumeroAgencia.Equals(nAgencia) && vetorContasCorrente[j].Conta.Equals(nConta))
                        {
                            Console.Write("Digita o valor que deseja sacar: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            vetorContasCorrente[j].sacarValor(valor);
                            Console.WriteLine($"Saque de R${valor} realizado com sucesso!");
                            break;
                        }
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Digite o nome do titular da conta que deseja verificar: ");
                    string ?nomeTitular = Console.ReadLine();

                    for (int j = 0; j < vetorContasCorrente.Length; j++)
                    {
                        if (vetorContasCorrente[j].Titular.Nome.Equals(nomeTitular))
                        {
                            vetorContasCorrente[j].exibirInformacoes();
                            break;
                        }
                    }
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Digite o número da sua agência: ");
                    int nroAgenciaRemetente = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o número da sua conta: ");
                    string ?nroContaRemetente = (Console.ReadLine());

                    for (int j = 0; j < vetorContasCorrente.Length; j++)
                    {
                        if (vetorContasCorrente[j].NumeroAgencia.Equals(nroAgenciaRemetente) && vetorContasCorrente[j].Conta.Equals(nroContaRemetente))
                        {
                            Console.Write("Digite o número da agência do destinatário: ");
                            int nroAgenciaDestinatario = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite o número da conta do destinatário: ");
                            string ?nroContaDestinatario = (Console.ReadLine());

                            for (int k = 0; k < vetorContasCorrente.Length; k++)
                            {
                                if (vetorContasCorrente[k].NumeroAgencia.Equals(nroAgenciaDestinatario) && vetorContasCorrente[k].Conta.Equals(nroContaDestinatario))
                                {
                                    Console.Write("Digita o valor que deseja transferir: ");
                                    double valor = Convert.ToDouble(Console.ReadLine());
                                    vetorContasCorrente[j].transferirValor(valor, vetorContasCorrente[k]);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Clear();
                    int total = ContaCorrente.TotalDeContas;
                    Console.WriteLine("Total de contas Cadastradas: " + total.ToString());
                    Console.ReadKey();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Programa finalizado!");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
    }
}

