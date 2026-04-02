using DesafioPratico1.Exercicio1;
using DesafioPratico1.Exercicio2;
using DesafioPratico1.Exercicio3;
using DesafioPratico1.Exercicio4;

class Program
{
    static void Main(string[] args)
    {
        BoasVindas boasVindas = new BoasVindas();
        boasVindas.SejaBemvindo();

        Concatenador concatenador = new Concatenador();
        concatenador.NomeCompleto();

        OperadorMatematico operadorMatematico = new OperadorMatematico();
        operadorMatematico.RealizarOperacoes();

        ContadorCaracteres contadorCaracteres = new ContadorCaracteres();
        contadorCaracteres.ContarCaracteres();
    }
}