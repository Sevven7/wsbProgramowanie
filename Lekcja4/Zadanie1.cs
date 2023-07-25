using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17062
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj liczbę liczb pierwszych do wygenerowania:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wygenerowane liczby pierwsze:");

            int liczba = 2; // Startujemy od pierwszej liczby pierwszej
            int licznik = 0; // Licznik wygenerowanych liczb pierwszych

            while (licznik < n)
            {
                if (CzyLiczbaPierwsza(liczba))
                {
                    Console.WriteLine(liczba);
                    licznik++;
                }

                liczba++;
            }
        }

        static bool CzyLiczbaPierwsza(int liczba)
        {
            if (liczba < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                    return false;
            }

            return true;
        }
    }
}