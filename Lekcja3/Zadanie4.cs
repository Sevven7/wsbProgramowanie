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

            SortowaniePrzezWstawianie(tablica);

            Console.WriteLine("Tablica po sortowaniu:");
            WypiszTablice(tablica);
        }

        static void SortowaniePrzezWstawianie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 1; i < n; i++)
            {
                int klucz = tablica[i];
                int j = i - 1;

                while (j >= 0 && tablica[j] > klucz)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                }

                tablica[j + 1] = klucz;
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