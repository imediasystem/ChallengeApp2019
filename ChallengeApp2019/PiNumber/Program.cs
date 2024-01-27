using System;

namespace PiNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wyświetla stałą PI z zadaną dokładnością.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("PI = {0:#.#####}.", Math.PI);
            Console.ResetColor();
        }
    }
}
