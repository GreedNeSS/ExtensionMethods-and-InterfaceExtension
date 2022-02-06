using System;
using System.Collections.Generic;

namespace InterfaceExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 5, 6, 7 };
            numbers.PrintDataAndBeep();

            Console.WriteLine();

            List<string> strings = new()
            {
                "Hello",
                "World",
                "Bye"
            };
            strings.PrintDataAndBeep();
        }
    }
}
