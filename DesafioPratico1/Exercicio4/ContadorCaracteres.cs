namespace DesafioPratico1.Exercicio4;

public class ContadorCaracteres
{
    public void ContarCaracteres()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();
        int quantidadeCaracteres = frase.Length;
        Console.WriteLine($"A quantidade de caracteres na frase é: {quantidadeCaracteres}");
    }
}
