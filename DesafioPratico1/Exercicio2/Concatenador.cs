namespace DesafioPratico1.Exercicio2;

public class Concatenador
{
    public void NomeCompleto()
    {
        Console.Write("Digite seu primeiro nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        string nomeCompleto = $"{nome} {sobrenome}";
        Console.WriteLine($"Seu nome completo é: {nomeCompleto.Trim()}");
    }
}
