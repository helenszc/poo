using Models;

namespace Oficina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu = new Pneu (10, "michelin");
            Carro corcel = new Carro("Chevrolet","2" );
            corcel.LigarDesligar();
            corcel.Abastecer(150);
            corcel.Acelerar(5);
            corcel.Frear(30);
            corcel.Acelerar(100);
            corcel.Frear(50);
            
            corcel.Exibir();


        }
    }
}