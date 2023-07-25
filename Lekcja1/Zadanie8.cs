using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, q, wynik;

        a = inputValue();
        b = inputValue();
        q = inputValue();
        if (q == 1)
        {
            wynik = a + b;
            Console.WriteLine(wynik);
        }
        else
        {
            if (q == 2)
            {
                wynik = a - b;
                Console.WriteLine(wynik);
            }
            else
            {
                if (q == 3)
                {
                    wynik = a * b;
                    Console.WriteLine(wynik);
                }
                else
                {
                    if (q == 4)
                    {
                        if (b == 0)
                        {
                            Console.WriteLine(a + "/" + b);
                        }
                        else
                        {
                            wynik = a / b;
                            Console.WriteLine(wynik);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Błędny operator");
                    }
                }
            }
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}