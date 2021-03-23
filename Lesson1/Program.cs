using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dtnow = DateTime.Now;

            Console.WriteLine("C# first program!");
            Console.WriteLine("The time: {0:d} at {0:t}", dtnow);

            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
