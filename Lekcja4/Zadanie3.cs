using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja17062
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj wysokość trójkąta:");
            int wysokosc = Convert.ToInt32(Console.ReadLine());

            RysujTrojkat(wysokosc);
        }

        static void RysujTrojkat(int wysokosc)
        {
            int szerokosc = wysokosc * 2 - 1;

            for (int wiersz = 1; wiersz <= wysokosc; wiersz++)
            {
                int iloscZnakow = wiersz * 2 - 1;
                int iloscSpacji = (szerokosc - iloscZnakow) / 2;

                string spacje = new string(' ', iloscSpacji);
                string znaki = new string('+', iloscZnakow);

                Console.WriteLine(spacje + znaki);
            }
        }
    }
}