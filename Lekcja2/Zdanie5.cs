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
            Console.WriteLine("Podaj wartość x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj liczbę wyrazów (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            double wynik = SzacujExp(x, n);

            Console.WriteLine("Wynik: " + wynik);
        }

        public static double SzacujExp(double x, int n)
        {
            double wynik = 1.0;
            double wyraz = 1.0;

            for (int i = 1; i < n; i++)
            {
                wyraz *= x / i;
                wynik += wyraz;
            }

            return wynik;
        }
    }
}