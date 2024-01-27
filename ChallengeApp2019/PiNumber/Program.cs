using System;

namespace PiNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wyświetla stałą PI z zadaną dokładnością.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Pi = {0:#.#####}.", Math.PI);
            Console.ResetColor();
        }
    }
}
