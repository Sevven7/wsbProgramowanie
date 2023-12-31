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
            int[,] tablica = new int[10, 10];
            int liczba = 1;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        tablica[i, j] = liczba;
                        liczba++;
                    }
                }
                else
                {
                    for (int j = 9; j >= 0; j--)
                    {
                        tablica[i, j] = liczba;
                        liczba++;
                    }
                }
            }

            // Wyświetlanie tablicy na ekranie
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}