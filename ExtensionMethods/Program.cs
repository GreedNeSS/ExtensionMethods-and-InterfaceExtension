using System;
using Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12345678;
            number.DisplayDefiningAssembly();

            System.Data.DataSet dataSet = new();
            dataSet.DisplayDefiningAssembly();

            System.Data.SqlDbType sqlDbType = new();
            sqlDbType.DisplayDefiningAssembly();

            Console.WriteLine($"number: {number}");
            Console.WriteLine($"Reversed digits of number: " +
                number.ReverseDigits());
        }
    }
}
