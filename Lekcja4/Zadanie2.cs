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
            Console.WriteLine("Podaj liczbę liczb parzystych do wygenerowania:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wersja 1 - Losowanie z poprawnością po losowaniu:");
            int[] wylosowaneLiczby1 = LosujLiczbyWersja1(n);
            WypiszLiczby(wylosowaneLiczby1);

            Console.WriteLine();

            Console.WriteLine("Wersja 2 - Losowanie od razu parzystej liczby:");
            int[] wylosowaneLiczby2 = LosujLiczbyWersja2(n);
            WypiszLiczby(wylosowaneLiczby2);
        }

        static int[] LosujLiczbyWersja1(int n)
        {
            Random random = new Random();
            int[] wylosowaneLiczby = new int[n];
            int iloscLosowan = 0;

            for (int i = 0; i < n; i++)
            {
                int liczba;

                do
                {
                    liczba = random.Next(-8, 9);
                    iloscLosowan++;
                } while (liczba % 2 != 0);

                wylosowaneLiczby[i] = liczba;
            }

            Console.WriteLine("Ilość losowań (wersja 1): " + iloscLosowan);

            return wylosowaneLiczby;
        }

        static int[] LosujLiczbyWersja2(int n)
        {
            Random random = new Random();
            int[] wylosowaneLiczby = new int[n];
            int iloscLosowan = 0;

            for (int i = 0; i < n; i++)
            {
                int liczba = random.Next(-4, 5) * 2;
                iloscLosowan++;
                wylosowaneLiczby[i] = liczba;
            }

            Console.WriteLine("Ilość losowań (wersja 2): " + iloscLosowan);

            return wylosowaneLiczby;
        }

        static void WypiszLiczby(int[] liczby)
        {
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write(liczby[i]);

                if (i < liczby.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}