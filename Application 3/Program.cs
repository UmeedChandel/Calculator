using ClassLibrary;

int i = 9;
Console.WriteLine(i.Square());

Console.WriteLine(" ");
Class2 obj2 = new Class2("Chandel");
Class2.staticNumber = 2000;
Console.WriteLine("Born in {0}, my age is {1} and last name is {2}", Class2.staticNumber, Class2.Age, obj2.name);

Console.WriteLine(" ");
int result = Class3.Add(99, 2);
Console.WriteLine("Partial Class Partial Static Add Result: {0}", result);
Console.WriteLine("My home state is {0}, work state now is {1}..", Class3.Home, Class3.Work);

Console.WriteLine(" ");
Class5 obj5 = new Class5();
Console.WriteLine("Abstarct Method1 Result: {0}", obj5.Method1(10));
Console.WriteLine("Virtual Method2 Result: {0}", obj5.Method2(1));

public class Class6 : Class4
{
    public override int Method1(int a)
    {
        return a * 30;
    }
    public void test()
    {
        this.Method3("Done");
    }
}