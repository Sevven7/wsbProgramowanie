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
            Console.WriteLine("Podaj liczbę x:");
            int x = Convert.ToInt32(Console.ReadLine());

            int n = SprawdzSilnie(x);

            if (n != -1)
            {
                Console.WriteLine(x + " jest silnią liczby " + n);
            }
            else
            {
                Console.WriteLine(x + " nie jest silnią żadnej liczby");
            }
        }

        public static int SprawdzSilnie(int x)
        {
            int n = 0;
            int silnia = 1;

            while (silnia <= x)
            {
                n++;

                if (silnia == x)
                {
                    return n;
                }

                silnia *= n;
            }

            return -1;
        }
    }
}