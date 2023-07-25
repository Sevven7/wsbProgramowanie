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

            SortowanieBabelkowe(tablica);

            Console.WriteLine("Tablica po sortowaniu:");
            WypiszTablice(tablica);
        }

        static void SortowanieBabelkowe(int[] tablica)
        {
            int n = tablica.Length;
            bool zamiana;

            for (int i = 0; i < n - 1; i++)
            {
                zamiana = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        // Zamiana miejscami
                        int temp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = temp;

                        zamiana = true;
                    }
                }
                if (!zamiana)
                    break;
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