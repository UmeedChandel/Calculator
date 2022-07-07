using System.Collections;
using System.Collections.Concurrent;

Console.WriteLine("Named Parameters and Optional Arguments");

int result = ArithmeticOperations.Add(10, 20);

int resultForOptionalArgument = ArithmeticOperations.Add(20);

int namedParameterResult = ArithmeticOperations.Add(b: 50, a: 25);

ArithmeticOperations.CustomMethod(10, "GL");

int result11 = ArithmeticOperations.CustomMethod(name: "GL", number: 10);


Console.WriteLine(result);
Console.WriteLine(resultForOptionalArgument);

Queue<string> stringQueue = new Queue<string>();   //thread-safe 

ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>(); //thread-safe

Console.WriteLine(" ");
Console.WriteLine("Lambda Function");

List<Task> tasks = new List<Task>();

//lamda function

for (int ii = 0; ii < 10000; ii++)
{
    Task task = Task.Run(() => concurrentQueue.Enqueue(10));
    tasks.Add(task);
}


await Task.WhenAll(tasks);


var numbers = new[] { 10, 25, 5, 87, 3, 5 };
int resulttt = numbers.OrderByDescending(n => n).ElementAt(2);
Console.WriteLine(resulttt);


//base class
GenA<Aishwarya> genA = new GenA<Aishwarya>();
GenA<Shraddha> genA1 = new GenA<Shraddha>();
GenA<Amara> genA2 = new GenA<Amara>();
GenA<Muskan> genA3 = new GenA<Muskan>();
GenA<Rahul> genA4 = new GenA<Rahul>();

//interface
GenB<IShashwat> genB = new GenB<IShashwat>();
GenB<Nanditha> genB1 = new GenB<Nanditha>();
GenB<Shreya> genB2 = new GenB<Shreya>();
GenB<Shriya> genB3 = new GenB<Shriya>();
GenB<Siddarth> genB4 = new GenB<Siddarth>();

//Struct type contraint
GenStruct<Simran> genStruct = new GenStruct<Simran>();
GenStruct<Sneha> genStruct1 = new GenStruct<Sneha>();
GenStruct<Sriram> genStruct2 = new GenStruct<Sriram>();
GenStruct<Subhash> genStruct3 = new GenStruct<Subhash>();
GenStruct<Umeed> genStruct4 = new GenStruct<Umeed>();
GenStruct<int> genStruct5 = new GenStruct<int>();

//reference types
GenReferenceType<Vaibhav> genReferenceType = new GenReferenceType<Vaibhav>();
GenReferenceType<Pujitha> genReferenceType1 = new GenReferenceType<Pujitha>();
GenReferenceType<Palak> genReferenceType2 = new GenReferenceType<Palak>();
GenReferenceType<Saurabh> genReferenceType3 = new GenReferenceType<Saurabh>();
GenReferenceType<Tisha> genReferenceType4 = new GenReferenceType<Tisha>();
GenReferenceType<Aman> genReferenceType5 = new GenReferenceType<Aman>();


//new() constraint
GenReferenceType<Aman> genReferenceType6 = new GenReferenceType<Aman>();

GenForAll<int> i1 = new GenForAll<int>();
GenForAll<string> str1 = new GenForAll<string>();
GenForAll<Subhash> subhash1 = new GenForAll<Subhash>();
GenForAll<Saurabh> saurabh1 = new GenForAll<Saurabh>();
GenForAll<IDisposable> saurabh11 = new GenForAll<IDisposable>();

class GenForAll<T>
{ }

class Student
{

}

class ArithmeticOperations
{
    public static int Add(int a, int b = 10)
    {
        return a + b;
    }

    public static int Divide(int a, int b = 1)
    {
        return a / b;
    }

    public static int CustomMethod(int number, string name = "GL")
    {
        return 0;
    }
}

//===============================================================


class NonGen
{
    Object ob;
    public NonGen(object o)
    {
        this.ob = o;
    }

    public object GetOb()
    {
        return ob;
    }

    public void ShowType()
    {
        Console.WriteLine(ob.GetType());
    }

}

//Try to convert it into Generic class

class Gen<T>
{
    T ob;
    public Gen(T o)
    {
        this.ob = o;
    }

    public T GetOb()
    {
        return ob;
    }

    public void ShowType()
    {
        Console.WriteLine(ob.GetType());
    }

}

//Generic struct, class, interface, delegate and methods

//Non Generic class with Generic method

//Generic abstract class
public abstract class AbsRemove<T>
{
    public abstract void RemoveAt(int index);
}

//Generic Interface
interface IMyStore<T>
{
    void AddElement(T item);
    T GetElement(int index);
    IEnumerable<T> Take(int number);

    IEnumerable<T> Skip(int number);

    void PrintElements();
}

class MyStore<T> : AbsRemove<T>, IMyStore<T>
{
    List<T> values = new List<T>();

    //Interface members
    public void AddElement(T item)
    {
        values.Add(item);
    }

    public T GetElement(int index)
    {
        return values[index];
    }

    public IEnumerable<T> Take(int number)
    {
        return values.Take(number);
    }

    public IEnumerable<T> Skip(int number)
    {
        return values.Skip(number);
    }

    public void PrintElements()
    {
        foreach (var item in values)
        {
            Console.WriteLine(item);
        }
    }

    //Abstract class member
    public override void RemoveAt(int index)
    {
        values.RemoveAt(index);
    }
}

//Not able to inherit from Abstract class, but can implement interfaces
struct MyStructStore<T> : IMyStore<T>
{
    List<T> values = new List<T>();

    public MyStructStore()
    {

    }

    public void AddElement(T item)
    {
        values.Add(item);
    }

    public T GetElement(int index)
    {
        return values[index];
    }

    public IEnumerable<T> Take(int number)
    {
        return values.Take(number);
    }

    public IEnumerable<T> Skip(int number)
    {
        return values.Skip(number);
    }

    public void PrintElements()
    {
        foreach (var item in values)
        {
            Console.WriteLine(item);
        }
    }

}

//Different versions of delegate needed to handle different types of data
public delegate int intArithemticDelegate(int number1, int number2);
public delegate double doubleArithmeticDelegate(double double1, double double2);
public delegate long longArithmeticDelegate(long double1, long double2);

//Generic delegate will handle both int and double now
public delegate T GenArithmeticDelegate<T>(T number1, T number2);


public class ArithmeticOperationsss
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

//Perfect scenario for comparing - using object
public class CompareObjects
{
    public static bool AreEqual(object value1, object value2)
    {
        return value1 == value2;
    }
}

//comparing functionality for different types of data
public class CompareMultipleObjects
{
    public static bool AreEqual(int value1, int value2)
    {
        return value1 == value2;
    }
    public static bool AreEqual(string value1, string value2)
    {
        return value1 == value2;
    }
    public static bool AreEqual(double value1, double value2)
    {
        return value1 == value2;
    }
}

//Gen compare
public class GenCompare<T>
{
    public static bool AreEqual(T value1, T value2)
    {
        return value1.Equals(value2);
    }
}

//==================================================================

class A
{
    public void Hello()
    {
        Console.WriteLine("Hello");
    }

}

//inherting A
class B : A { }

//not inherting A
class C { }

class GenTest<T> where T : A
{
    T ob;

    public GenTest(T o)
    {
        ob = o;
    }
    public void SayHello()
    {
        ob.Hello();
    }
}


//Base class constraints

class Aishwarya { }
class Amara : Aishwarya { }
class Shraddha : Aishwarya { }
class Muskan : Aishwarya { }
class Rahul : Aishwarya { }
class GenA<T> where T : Aishwarya { }



//Interface contraints
interface IShashwat { }
class Nanditha : IShashwat { }
class Shreya : IShashwat { }
class Shriya : IShashwat { }
class Siddarth : IShashwat { }
class GenB<T> where T : IShashwat { }


//Struct contraints (value type)
//user defined struct types - complex value types
struct Simran { }
struct Sneha { }
struct Sriram { }
struct Subhash { }
struct Umeed { }

class GenStruct<T> where T : struct { }


class Vaibhav { }
class Pujitha { }
class Palak { }
class Saurabh { }
class Tisha { }
class Aman
{
    public Aman()
    {

    }
    public Aman(string name)
    {

    }
}

class GenReferenceType<T> where T : class, new() { }


class GenForTest<T> where T : IShashwat { }