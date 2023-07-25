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
            Console.WriteLine("Podaj współrzędne punktu początkowego (x1, y1):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj współrzędne punktu końcowego (x2, y2):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double dlugosc = ObliczDlugoscOdcinka(x1, y1, x2, y2);
            Console.WriteLine("Długość odcinka: " + dlugosc);

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }

        static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;

            double dlugosc = Math.Sqrt(dx * dx + dy * dy);

            return dlugosc;
        }
    }
}