namespace DesafioPratico1.Exercicio1;

public class BoasVindas
{
    public void SejaBemvindo()
    {
        Console.Write("Digite seu nome: ");
        string username = Console.ReadLine();

        Console.WriteLine($"Olá, {username}! seja bem-vindo ao curso de C#!");
    }
}
