using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2406
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar;
            bool poprawnyRozmiar = false;

            do
            {
                Console.Write("Podaj rozmiar tablicy (liczba wierszy i kolumn): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out rozmiar) && rozmiar > 0)
                {
                    poprawnyRozmiar = true;
                }
                else
                {
                    Console.WriteLine("Niepoprawny rozmiar tablicy. Spróbuj jeszcze raz.");
                }
            } while (!poprawnyRozmiar);

            int[,] tablica = new int[rozmiar, rozmiar];
            int liczba = 1;

            for (int i = 0; i < rozmiar; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < rozmiar; j++)
                    {
                        tablica[i, j] = liczba;
                        liczba++;
                    }
                }
                else
                {
                    for (int j = rozmiar - 1; j >= 0; j--)
                    {
                        tablica[i, j] = liczba;
                        liczba++;
                    }
                }
            }

            // Wyświetlanie tablicy na ekranie
            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}