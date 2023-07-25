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
        double a, b, c;

        a = inputValue();
        b = inputValue();
        c = inputValue();
        if (a == b)
        {
            if (b == c)
            {
                Console.WriteLine("Trójkąt jest równoboczny");
            }
            else
            {
                Console.WriteLine("Trójkąt nie jest równoboczny");
            }
        }
        else
        {
            Console.WriteLine("Trójkąt nie jest równoboczny");
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