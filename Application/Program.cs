// See https://aka.ms/new-console-template for more information

using InheritanceLibrary;
class Program
{
    public static void Main(string[] args)
    {
       
        A obj1 = new A();
        B obj2 = new B();
        C obj3 = new C();
        D obj4 = new D();

        Console.WriteLine("Base Class Virtual A Method: " + obj1.Divide(10, 10));
        Console.WriteLine("Drived Class Override B Method: " + obj2.Divide(20, 10));
        Console.WriteLine("Drived Class Override C Method: " + obj3.Divide(30, 10));
        obj4.Method2();
        
    }
}



