using System;
using StaticClaculatorLibrary;

namespace StaticCalculationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StaticCalculatorOperations.Addition(5, 55);

            Console.WriteLine(StaticCalculatorOperations.result);
            Console.WriteLine(StaticCalculatorOperations.Subtract(100, 65));
            Console.WriteLine(StaticCalculatorOperations.Multiplication(12, 78));
            Console.WriteLine(StaticCalculatorOperations.Division(46, 9));

        }
    }
}