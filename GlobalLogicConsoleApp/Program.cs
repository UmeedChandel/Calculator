using System;
using Calculator;
namespace GlobalLogicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ClassOperations operations = new ClassOperations();

            int result1 = operations.Addition(10);
            Console.WriteLine("add(Over load 1): "+result1.ToString());

            int result11 = operations.Addition(10, 11);
            Console.WriteLine("add(Over load 2): " + result11.ToString());

            int result111 = operations.Addition(10, 11, 10);
            Console.WriteLine("add(Over load 3): " + result111.ToString());

            int result2 = operations.Subtract(10, 10);
            Console.WriteLine(result2.ToString());

            int result22 = operations.Subtract(20, 10, 5);
            Console.WriteLine(result22.ToString());


            int result3 = operations.Multiplication(10);
            Console.WriteLine(result3.ToString());

            int result33 = operations.Multiplication(10, 5);
            Console.WriteLine(result33.ToString());


            int result4 = operations.Division(10, 10);
            Console.WriteLine(result4.ToString());

            int result44 = operations.Division(10, 5, 24);
            Console.WriteLine(result44.ToString());

            ExtraOperations extra = new ExtraOperations();
            string companyName = extra.Concat("Global", "Logic");
            Console.WriteLine(companyName);

            ExtraOperations cons1 = new ExtraOperations();
            ExtraOperations cons2 = new ExtraOperations(10);
            ExtraOperations cons3 = new ExtraOperations(10,10);
            ExtraOperations cons4 = new ExtraOperations(10,"GL");
            ExtraOperations cons5 = new ExtraOperations("WELCOME",10);
            ExtraOperations cons6 = new ExtraOperations(10,10,10);
            ExtraOperations cons7 = new ExtraOperations(10, 10, "Hello");
            ExtraOperations cons8 = new ExtraOperations(10, "World", 10);
            ExtraOperations cons9 = new ExtraOperations(10, 10, 10, 10);

            Console.WriteLine("result string: " + cons8.result);
            Console.WriteLine("firstNumber: " + cons9.firstNumber);


            Console.Read();

        }
    }
}
