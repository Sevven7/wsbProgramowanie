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
            int wiersz = 0, kolumna = 0;
            int kierunek = 0; // 0 - w prawo, 1 - w dół, 2 - w lewo, 3 - w górę

            while (liczba <= rozmiar * rozmiar)
            {
                tablica[wiersz, kolumna] = liczba;

                switch (kierunek)
                {
                    case 0: // w prawo
                        kolumna++;
                        if (kolumna == rozmiar || tablica[wiersz, kolumna] != 0)
                        {
                            kolumna--;
                            wiersz++;
                            kierunek = 1; // zmiana kierunku na w dół
                        }
                        break;
                    case 1: // w dół
                        wiersz++;
                        if (wiersz == rozmiar || tablica[wiersz, kolumna] != 0)
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