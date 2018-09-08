using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            Console.WriteLine(randomNumber);
            Console.WriteLine("Input your nimber");
            a = Convert.ToInt32(Console.ReadLine());         
            bool b = a > randomNumber;
            Console.WriteLine("{0}>{1} : {2}", a, randomNumber, b);
            Console.ReadKey();

            
        }


    }
}
