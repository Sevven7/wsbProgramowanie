using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja1706
{
    class Program
    {
        static void Main()
        {
            int[] tablica = GenerujTablice(10); // Wywołanie funkcji GenerujTablice() tworzy tablicę o 10 losowych wartościach

            Console.WriteLine("Zawartość tablicy od tyłu:");

            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tablica[i]);
            }
        }

        static int[] GenerujTablice(int rozmiar)
        {
            Random random = new Random();
            int[] tablica = new int[rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                tablica[i] = random.Next(100); // Losowa wartość z zakresu 0-99
            }
            return tablica;
        }
    }
}