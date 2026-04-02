using DesafioPratico1.Exercicio1;
using DesafioPratico1.Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        BoasVindas boasVindas = new BoasVindas();
        boasVindas.SejaBemvindo();

        Concatenador concatenador = new Concatenador();
        concatenador.NomeCompleto();
    }
}