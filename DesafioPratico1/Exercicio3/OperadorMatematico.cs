namespace DesafioPratico1.Exercicio3;

public class OperadorMatematico
{
    private Double numero1 = 17.5;
    private Double numero2 = 22.2;

    public void RealizarOperacoes()
    {
        Console.WriteLine($"Números utilizados: {numero1} e {numero2}");
        CalcularSoma();
        CalcularSubtracao();
        CalcularMultiplicacao();
        CalcularDivisao();
        CalcularMedia();
    }

    public void CalcularSoma()
    {
        double resultado = numero1 + numero2;
        Console.WriteLine($"A soma de {numero1} e {numero2} é: {resultado}");
    }

    public void CalcularSubtracao()
    {
        double resultado = numero1 - numero2;
        Console.WriteLine($"A subtração de {numero1} e {numero2} é: {resultado}");
    }

    public void CalcularMultiplicacao()
    {
        double resultado = numero1 * numero2;
        Console.WriteLine($"A multiplicação de {numero1} e {numero2} é: {resultado}");
    }

    public void CalcularDivisao()
    {
        if (numero2 != 0)
        {
            double resultado = numero1 / numero2;
            Console.WriteLine($"A divisão de {numero1} por {numero2} é: {resultado}");
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }
    }

    public void CalcularMedia()
    {
        double resultado = (numero1 + numero2) / 2;
        Console.WriteLine($"A média de {numero1} e {numero2} é: {resultado}");
    }
}
