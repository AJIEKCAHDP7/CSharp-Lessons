using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Arithmetic expressions
            Console.WriteLine("1. Arithmetic expressions");
            // 1.1. Display the number to the nearest hundredths.
            Console.WriteLine("1.1. Display the number to the nearest hundredths.");
            double dbnumber = 10.99;
            Console.WriteLine("Decimal number: ", dbnumber);
            Console.WriteLine("--- /// ---");


            DateTime dtnow = DateTime.Now;
            Console.WriteLine("The time: {0:d} at {0:t}", dtnow);

            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
