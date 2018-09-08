using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, x = 5, y = 2;
            Double a1 = 0;
            a1= a + b;
            Console.WriteLine("..a + b....{0}", a1);

            a = 10;
            b = 20;
            x = 5;
            y = 2;
            a1 = 0;
            a1 = x - b;
            Console.WriteLine("..x-b....{0}", a1);

            a = 10;
            b = 20;
            x = 5;
            y = 2;
            a1 = 0;
            a1 = x * b;
            Console.WriteLine("..x*b....{0}", a1);

            a = 10;
            b = 20;
            x = 5;
            y = 2;
            a1 = 0;
            a1 = y / a;
            Console.WriteLine("..y/a....{0}", a1);

            a = 10;
            b = 20;
            x = 5;
            y = 2;
            a1 = 0;
            a1 = b % y;
            Console.WriteLine("..b%y....{0}", a1);

            a = 10;
            b = 20;
            x = 5;
            y = 2;
            a1 = 0;
            a1 = y + 10 % x;
            Console.WriteLine("..y+10%x....{0}", a1);

            a = 10;
            b = 20;
            x = 5;
            y = 2;
            a1 = 0;
            a1 = a / 3 * 5;
            Console.WriteLine("..a/3*5....{0}", a1);

            a = 10;
            b = 20;
            x = 5;
            y = 2;
            a1 = 0;
            a1 = 9 / 2 * a;
            Console.WriteLine("..9/2*a....{0}", a1);

            a = 10;
            b = 20;
            x = 5;
            y = 2;
            a1 = 0;
            a1 = y % 8;
            Console.WriteLine("..y%8....{0}", a1);

            a = 10;
            b = 20;
            x = 5;
            y = 2;
            a1 = 0;
            a1 = 100 * x + y % 2 - a;
            Console.WriteLine("..100*x+y%2-a....{0}", a1);
            Console.ReadKey();

            
        }


    }
}
