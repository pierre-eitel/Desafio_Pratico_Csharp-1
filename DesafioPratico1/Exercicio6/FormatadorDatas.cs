using System.Globalization;

namespace DesafioPratico1.Exercicio6;

public class FormatadorDatas
{
    public void FormatarData()
    {
        DateTime agora = DateTime.Now;

        var cultura = new CultureInfo("pt-BR");

        Console.WriteLine("Formato completo:");
        Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", cultura));

        Console.WriteLine("\nApenas data:");
        Console.WriteLine(agora.ToString("dd/MM/yyyy"));

        Console.WriteLine("\nApenas hora:");
        Console.WriteLine(agora.ToString("HH:mm:ss"));

        Console.WriteLine("\nMês por extenso:");
        Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", cultura));
    }
}
