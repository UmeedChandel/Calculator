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
            int result1 = operations.Add(10, 10);
            Console.WriteLine(result1.ToString());
    

            int result2 = operations.Sub(10, 10);
            Console.WriteLine(result2.ToString());
       

            int result3 = operations.Multiplication(10, 10);
            Console.WriteLine(result3.ToString());
     

            int result4 = operations.Division(10, 10);
            Console.WriteLine(result4.ToString());
         

            ExtraOperations extra = new ExtraOperations();
            string companyName = extra.Concat("Global", "Logic");
            Console.WriteLine(companyName);


            Console.Read();

        }
    }
}
