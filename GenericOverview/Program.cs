using System.Collections;
using System.Collections.Concurrent;

//Non-Generic Stack

Stack intNonGenericStack = new Stack();// creating object for non-generic stack
intNonGenericStack.Push(10); // pushing elements, boxing - int -> object then stored inside stack
intNonGenericStack.Push(20);
intNonGenericStack.Push(30);
intNonGenericStack.Push(new Student()); // it is allowed, no compile time type checking, because it accepts as object.

Console.WriteLine("Non-Generic Stack");
//Console.WriteLine((int?)intNonGenericStack.Pop()); //pop up elements from stack, unbox your elements
Console.WriteLine(intNonGenericStack.Pop());
Console.WriteLine(intNonGenericStack.Pop());
Console.WriteLine(intNonGenericStack.Pop());


Stack stringNonGenericStack = new Stack();

intNonGenericStack = stringNonGenericStack; // it is allowed, syntactically correct, but throws run time error

List<Student> studentList = new List<Student>();

ArrayList object1 = new ArrayList();

int i = 10;

int j = i;

//Stack intNonGenericStack = new Stack();

Stack<int> intStack = new Stack<int>(); //creating object for generic stack and it is integer version,
                                        //allows only integer, no boxing and unboxing, compile time validation
intStack.Push(100);
//intStack.Push("string");//compilatin time itself generics throws error, compile time type checking.
intStack.Push(20);
intStack.Push(30);

Console.WriteLine("Int version of Generic Stack");//unboxing, no explicit casting.
Console.WriteLine(intStack.Pop());
Console.WriteLine(intStack.Pop());
Console.WriteLine(intStack.Pop());


Stack<string> stringStack = new Stack<string>();
stringStack.Push("Shraddha");
stringStack.Push("Shashwat");
stringStack.Push("Shreya");
stringStack.Push("Shriya");
stringStack.Push("Siddarth");
stringStack.Push("Simran");
stringStack.Push("Sneha");
stringStack.Push("Sriram");
stringStack.Push("Saurabh");


Stack<Student> studentStack = new Stack<Student>();
studentStack.Push(new Student());


//intStack = stringStack; // compiler error, not possible, they are 2 identical versions, even though object of same class.

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


Print print = new Print();
print.PrintData<int>(10);
print.PrintData<string>("Hello GL");


GenArithmeticDelegate<int> genArithmeticDelegate = new GenArithmeticDelegate<int>(ArithmeticOperations.Add);
int genResult = genArithmeticDelegate.Invoke(10, 10);





NonGen nonGen = new NonGen(10);
int value = (int)nonGen.GetOb();
nonGen.ShowType();
/*
Gen<int> intGen = new Gen<int>(100);
int genValue = intGen.GetOb();*/




NonGen nonGen1 = new NonGen(10);
int value123 = (int)nonGen1.GetOb(); //typecasting


//when you are creating object for your generic class, you have pass concrete type - primitive types or user defined types
Gen<int> intGen = new Gen<int>(100);
int genResult123 = intGen.GetOb();

Gen<double> doubleGen = new Gen<double>(500);
double doubleResult123 = doubleGen.GetOb();

/*class Print<T>{
 
 public void PrintData(int item)
    {
        Console.WriteLine(item);
    }
  
 public void PrintData<T>(T item)
{
    Console.WriteLine(item);
}
}*/


Print print123 = new Print();
//print123.PrintData(10);
print123.PrintData<int>(10);
print123.PrintData<double>(1000);


/*class GenClass<T>
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public void Print<V>(V item)
    {
        Console.WriteLine(item);
    }

}
*/

GenClass<string> stringGenClass = new GenClass<string>();
stringGenClass.Print<double>(10);
stringGenClass.Print("");
stringGenClass.Add(10, 10);





MyStore<int> myStoreObject = new MyStore<int>();
myStoreObject.AddElement(10);
var element = myStoreObject.GetElement(0);

MyStore<string> myStoreStringVersion = new MyStore<string>();
myStoreStringVersion.AddElement("Hello My Guys");
var elementAsString = myStoreStringVersion.GetElement(0);


/*public class GenCompare<T>
{
    public static bool AreEqual(T value1, T value2)
    {
        return value1.Equals(value2);
    }
}*/

GenCompare<int>.AreEqual(10, 10);
GenCompare<string>.AreEqual("Good", "Good");

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
class Print
{
    //Mulitiple versions for different types of data

    //One version will handle most of the types of data
    public void PrintData<T>(T item)
    {
        Console.WriteLine(item);
    }
}

//Generic class with non-generic and generic methods
class GenClass<T>
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public void Print<V>(V item)
    {
        Console.WriteLine(item);
    }

}

//Generic abstract class
public abstract class AbsRemove<T>
{
    public abstract void RemoveAt(int index);
}

//Generic Interface
//{10,20,30,40,50 }
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