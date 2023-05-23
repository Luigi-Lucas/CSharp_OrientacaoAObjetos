using Desafio_1;

internal class Program
{
    public static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();

        Console.WriteLine(pessoa.nome);
        Console.WriteLine(pessoa.idade);
        Console.WriteLine(pessoa.altura);
        Console.WriteLine(pessoa.peso);
    }
}