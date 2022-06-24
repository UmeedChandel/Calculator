﻿// See https://aka.ms/new-console-template for more information

using IVariousOperationscs;
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

        Console.WriteLine(" ");

        Console.WriteLine("Interfaces =>");

        //class object - instantiation

        Console.WriteLine("Class One: ");
        ClassOne obj6 = new ClassOne();
        Console.WriteLine(obj6.func2(1));
        Console.WriteLine(obj6.func3(1));
        Console.WriteLine(obj6.extrafunc(1));

        //interface object - declaration

        Console.WriteLine("Interface One: ");
        IOneInterface oneInterface = new ClassOne();
        Console.WriteLine(oneInterface.func(2));

        Console.WriteLine("Interface Two: ");
        ITwoInterface twoInterface = new ClassOne();
        Console.WriteLine(twoInterface.func2(2));
        Console.WriteLine(twoInterface.func3(3));

        Console.WriteLine("Class Two: ");
        ClassTwo obj7 = new ClassTwo();
        Console.WriteLine(obj7.Test());

        Console.WriteLine("Structure One: ");
        OneStructure obj8 = new OneStructure();
        Console.WriteLine(obj8.func4(1000));

        Console.WriteLine("Structure Two: ");
        TwoStructure obj9 = new TwoStructure();
        Console.WriteLine(obj9.func2(2));
        Console.WriteLine(obj9.func3(3));

    }
}




