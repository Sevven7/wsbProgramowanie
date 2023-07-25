using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2406._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj czas w sekundach:");
            int czas = int.Parse(Console.ReadLine());

            string sformatowanyCzas = FormatujCzas(czas);
            Console.WriteLine("Sformatowany czas: " + sformatowanyCzas);

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static string FormatujCzas(int czas)
        {
            int godziny = czas / 3600;
            int minuty = (czas % 3600) / 60;
            int sekundy = czas % 60;

            string sGodziny = godziny.ToString("00");
            string sMinuty = minuty.ToString("00");
            string sSekundy = sekundy.ToString("00");

            return $"{sGodziny}:{sMinuty}:{sSekundy}";
        }
    }
}