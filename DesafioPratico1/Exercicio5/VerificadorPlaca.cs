namespace DesafioPratico1.Exercicio5;

public class VerificadorPlaca
{
    public void VerificarPlaca()
    {
        Console.Write("Digite a placa do veículo (formato ABC1D23): ");
        string placa = Console.ReadLine().Trim();
        if (IsPlacaValida(placa))
        {
            Console.WriteLine("A placa é válida.");
        }
        else
        {
            Console.WriteLine("A placa é inválida. O formato correto é ABC1D23.");
        }
    }

    private bool IsPlacaValida(string placa)
    {
        if (string.IsNullOrEmpty(placa) || placa.Length != 7)
        {
            return false;
        }
        string letras = placa.Substring(0, 3);
        char numero1 = placa[3];
        char letra = placa[4];
        string numeros = placa.Substring(5, 2);
        return letras.All(char.IsLetter) && char.IsDigit(numero1) && char.IsLetter(letra) && numeros.All(char.IsDigit);
    }
}
