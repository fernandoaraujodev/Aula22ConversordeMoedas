using System;

namespace Aula22ConversorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"US$83 são R${Conversor.DolarxReal(83)}");
            Console.WriteLine($"R$83 são US${Conversor.RealxDolar(83)}");

            Console.WriteLine($"67€ são R${Conversor.EuroxReal(67)}"); 
            Console.WriteLine($"R$67 são €{Conversor.RealxDolar(67)}");

        }
    }
}
