using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lekcja1006
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, k;

            do
            {
                Console.WriteLine("Podaj liczbę n (n >= 5):");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 5);

            do
            {
                Console.WriteLine("Podaj liczbę k (k >= 5):");
                k = Convert.ToInt32(Console.ReadLine());
            } while (k < 5);

            long wynik = ObliczM(n, k);

            Console.WriteLine("Wynik: " + wynik);
        }

        public static long ObliczM(int n, int k)
        {
            long m;

            long nSilnia = Silnia(n);
            long kSilnia = Silnia(k);

            m = (nSilnia - kSilnia) / kSilnia;

            return m;
        }

        public static long Silnia(int liczba)
        {
            if (liczba <= 1)
                return 1;

            long wynik = 1;

            for (int i = 2; i <= liczba; i++)
            {
                wynik *= i;
            }

            return wynik;
        }
    }
}