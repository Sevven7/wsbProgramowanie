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
            Console.WriteLine("Podaj liczbę n:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pary liczb naturalnych o sumie " + n + ":");

            WypiszPary(n);
        }

        public static void WypiszPary(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                int j = n - i;

                Console.WriteLine(i + " + " + j);
            }
        }
    }
}