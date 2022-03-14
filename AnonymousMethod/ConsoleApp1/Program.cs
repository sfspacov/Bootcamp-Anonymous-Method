using System;

namespace ConsoleApp1
{
    class Program
    {
        public delegate void Print(int value);

        public static void PrintMetodo(Print print, int val)
        {
            print(val + 10);
        }

        static void Main(string[] args)
        {
            Print print = delegate(int val)
            {
                Console.WriteLine("Numero x: " + val);
            };

            PrintMetodo(print, 10);
        }
    }
}
