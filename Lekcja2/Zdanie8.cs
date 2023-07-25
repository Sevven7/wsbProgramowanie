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
            Console.WriteLine("Wybierz liczbę z przedziału 1-20.");

            int dolnyPrzedzial = 1;
            int gornyPrzedzial = 20;
            int propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;

            while (true)
            {
                Console.WriteLine("Czy Twoja liczba to " + propozycja + "?");
                Console.WriteLine("Wprowadź: ");
                Console.WriteLine("-1, jeśli Twoja liczba jest mniejsza");
                Console.WriteLine("1, jeśli Twoja liczba jest większa");
                Console.WriteLine("0, jeśli zgadłem liczbę!");

                int odpowiedz = Convert.ToInt32(Console.ReadLine());

                if (odpowiedz == -1)
                {
                    gornyPrzedzial = propozycja - 1;
                    propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;
                }
                else if (odpowiedz == 1)
                {
                    dolnyPrzedzial = propozycja + 1;
                    propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;
                }
                else if (odpowiedz == 0)
                {
                    Console.WriteLine("Odgadłem Twoją liczbę!");
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa odpowiedź. Wprowadź -1, 1 lub 0.");
                }
            }
        }
    }
}