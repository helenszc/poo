using Models;

internal class Program
{
    private static void Main(string[] args)
    {

        Models.Caneta caneta = new Models.Caneta("Azul", "Bic", "Plastico");

        Lapis lapis = new Lapis("2B");
        lapis.Escrever("teste");
    }
}
