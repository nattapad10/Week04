using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b;
           
            Console.WriteLine("Input your distance of the sun");
            a = Convert.ToDouble(Console.ReadLine());
            a = a / 1.609344; //min
            b = a;
            a = a / 93000000; //au
            b = b / 186000; //wi
            b = b / 100;
            Console.WriteLine("distance A.U. is {0}",a);
            Console.WriteLine("distance light min is {0}",b);
            Console.ReadKey();

            
        }


    }
}
