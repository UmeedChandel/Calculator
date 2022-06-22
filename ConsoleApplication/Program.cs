using System;
using Calculator;
using AccessModifiers;

namespace BasicCalculatorConsole
{
    class Program : AccessModOp1
    {
        Program obj = new Program();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClassOperations1 o1 = new ClassOperations1();
            o1.invoke1();

            AccessModOp3 o2 = new AccessModOp3();
            o2.invoke2();

            o1.invoke3();

            ClassOperations o3 = new ClassOperations();
            o3.invoke4();

            Console.WriteLine(o1.Operation1(10)); //only public accessable

            Console.WriteLine("Protected Internal Access Advantage");

            //Console.WriteLine(this.Operation5(10, 10));
        }

    }


}