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
            int wiersz = 0, kolumna = 0;
            int kierunek = 0; // 0 - w prawo, 1 - w dół, 2 - w lewo, 3 - w górę

            while (liczba <= 100)
            {
                tablica[wiersz, kolumna] = liczba;

                switch (kierunek)
                {
                    case 0: // w prawo
                        kolumna++;
                        if (kolumna == 10 || tablica[wiersz, kolumna] != 0)
                        {
                            kolumna--;
                            wiersz++;
                            kierunek = 1; // zmiana kierunku na w dół
                        }
                        break;
                    case 1: // w dół
                        wiersz++;
                        if (wiersz == 10 || tablica[wiersz, kolumna] != 0)
                        {
                            wiersz--;
                            kolumna--;
                            kierunek = 2; // zmiana kierunku na w lewo
                        }
                        break;
                    case 2: // w lewo
                        kolumna--;
                        if (kolumna == -1 || tablica[wiersz, kolumna] != 0)
                        {
                            kolumna++;
                            wiersz--;
                            kierunek = 3; // zmiana kierunku na w górę
                        }
                        break;
                    case 3: // w górę
                        wiersz--;
                        if (wiersz == -1 || tablica[wiersz, kolumna] != 0)
                        {
                            wiersz++;
                            kolumna++;
                            kierunek = 0; // zmiana kierunku na w prawo
                        }
                        break;
                }

                liczba++;
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