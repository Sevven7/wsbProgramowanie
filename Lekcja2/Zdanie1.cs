using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lekcja1006
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj podstawę:");
            int podstawa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj wykładnik:");
            int wykladnik = Convert.ToInt32(Console.ReadLine());

            int wynik = Poteguj(podstawa, wykladnik);
            Console.WriteLine("Wynik: " + wynik);
        }

        public static int Poteguj(int podstawa, int wykladnik)
        {
            int wynik = 1;

            for (int i = 0; i < wykladnik; i++)
            {
                wynik *= podstawa;
            }

            return wynik;
        }
}
}