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
            int[] tablica = { 5, 2, 8, 1, 3 }; // Tablica wejściowa

            Console.WriteLine("Tablica przed sortowaniem:");
            WypiszTablice(tablica);

            SortowaniePrzezWybieranie(tablica);

            Console.WriteLine("Tablica po sortowaniu:");
            WypiszTablice(tablica);
        }

        static void SortowaniePrzezWybieranie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int indeksMinimum = i;

                // Znajdowanie indeksu najmniejszego elementu w nieposortowanej części tablicy
                for (int j = i + 1; j < n; j++)
                {
                    if (tablica[j] < tablica[indeksMinimum])
                    {
                        indeksMinimum = j;
                    }
                }

                // Zamiana miejscami najmniejszego elementu z pierwszym elementem nieposortowanej części
                int temp = tablica[i];
                tablica[i] = tablica[indeksMinimum];
                tablica[indeksMinimum] = temp;
            }
        }

        static void WypiszTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine();
        }
    }
}