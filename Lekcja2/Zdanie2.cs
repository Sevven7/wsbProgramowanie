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
            Console.WriteLine("Podaj liczbę wyrazów do wygenerowania:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ciąg Fibonacciego:");
            for (int i = 0; i < n; i++)
            {
                int wynik = Fibonacci(i);
                Console.WriteLine(wynik);
            }
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            int a = 0;
            int b = 1;
            int wynik = 0;

            for (int i = 2; i <= n; i++)
            {
                wynik = a + b;
                a = b;
                b = wynik;
            }

            return wynik;
        }
    }
}