// See https://aka.ms/new-console-template for more information

using InheritanceLibrary;
using StaticConstReadonly;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Inheritance Virtual & Overrideing =>");

        AA obj1 = new AA();
        BB obj2 = new BB();
        CC obj3 = new CC();
        DD obj4 = new DD();

        Console.WriteLine("Base Class Virtual A Method: " + obj1.Divide(10, 10));
        Console.WriteLine("Drived Class Override B Method: " + obj2.Divide(20, 10));
        Console.WriteLine("Drived Class Override C Method: " + obj3.Divide(30, 10));
        obj4.Method2();

        Console.WriteLine(" ");

        Console.WriteLine("Static & Readonly & Constant =>");

        B obj5 = new B();

        Console.WriteLine(obj5.Test());

    }
}




