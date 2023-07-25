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
            Console.WriteLine("Podaj kwotę początkową:");
            decimal kwotaPoczatkowa = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Podaj oprocentowanie w skali roku:");
            decimal oprocentowanie = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Podaj liczbę miesięcy oszczędzania:");
            int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

            decimal kwotaZarobiona = ObliczKwoteZarobiona(kwotaPoczatkowa, oprocentowanie, liczbaMiesiecy);

            Console.WriteLine("Kwota zarobiona: " + kwotaZarobiona);
        }

        public static decimal ObliczKwoteZarobiona(decimal kwotaPoczatkowa, decimal oprocentowanie, int liczbaMiesiecy)
        {
            decimal podatekBelki = 0.19m; // Podatek Belki wynosi 19% (0.19)

            decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100; // Oprocentowanie w skali miesiąca

            decimal kwotaZarobiona = kwotaPoczatkowa * (decimal)Math.Pow(1 + (double)oprocentowanieMiesieczne, liczbaMiesiecy);

            kwotaZarobiona *= (1 - podatekBelki); // Pomniejszenie kwoty o podatek Belki

            return kwotaZarobiona;
        }
    }
}