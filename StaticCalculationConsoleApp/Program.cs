using System;
using StaticClaculatorLibrary;

namespace StaticCalculationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Enter: ");

            try
            {
                int inputNum = int.Parse(Console.ReadLine());
                Console.WriteLine(inputNum);
                Console.WriteLine(StaticCalculatorOperations.Division(46, 0));
                //string str = null;
                //bool length = str.Contains("a");
            }
            catch (DivideByZeroException Dex)
            {
                Console.WriteLine(Dex.StackTrace);
            }
            catch (NullReferenceException Nex)
            {
                Console.WriteLine("Null Catch Block 1: " + Nex.Message);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Format Catch Block 2: " + fex.Message);
            }
            //parent catch block handels all the exception
            catch (Exception ex)
            {
                Console.WriteLine("Base Catch Block 3: " + ex.Message);
            }
            finally
            {
                Console.WriteLine(" ");
                Console.WriteLine("Final Code");
                Console.WriteLine(" ");
            }

            
            
            StaticCalculatorOperations.Addition(5, 55);

            Console.WriteLine(StaticCalculatorOperations.result);
            Console.WriteLine(StaticCalculatorOperations.Subtract(100, 65));
            Console.WriteLine(StaticCalculatorOperations.Multiplication(12, 78));
            Console.WriteLine(StaticCalculatorOperations.Division(46, 9));

        }
    }
}