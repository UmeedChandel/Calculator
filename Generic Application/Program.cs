using GenericClassLibrary;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Generic object for NO parameter: ");
        Gen GenObj = new Gen(10);
        GenObj.GetValues();
        GenObj.GetType();

        Console.WriteLine("Generic object for (1) parameter: ");
        Gen1<int> intGen = new Gen1<int>(); // integer version of Gen 
        //Gen1<string> stringGen = new Gen1<string>(); // string version of Gen class restricted by constraints
        intGen.Add(10,20);
        intGen.Multiply(10,2);

        Console.WriteLine("Generic object for (2) parameter: ");
        Gen2<string, int> gen2 = new Gen2<string, int>(); // gen2 is version of integer and string
        gen2.GetName("Umeed");
        gen2.GetId(177);

        Console.WriteLine("Generic object for (3) parameter: ");
        Gen3<int, string, bool> gen3 = new Gen3<int, string, bool>(10, "Three Generic Para!!",true); 
        gen3.GetValues();
        gen3.GetTypes();

        //Generic object along with constraints

        GenForBaseClassType<Product> productVersionOfGen = new GenForBaseClassType<Product>(); ;

        GenForInterfaceType<IProduct> genForInterfaceType = new GenForInterfaceType<IProduct>();
        GenForContructorType<Car> carVersionOfGen = new GenForContructorType<Car>();

        GenForValueType<int> intGenWithContraint = new GenForValueType<int>();
        GenForValueType<color> genForValueType = new GenForValueType<color>();

        GenForReferenceType<string> stringGenWithContraint = new GenForReferenceType<string>();
        GenForReferenceType<IProduct> genForReferenceType = new GenForReferenceType<IProduct>();

        //GenForValueType<string> stringObject = new GenForValueType<string>();//error, because string is not value type


        //Generic Algorithms

        Console.WriteLine("String Stack: ");
        Stack<string> strStack = new Stack<string>();
        strStack.Push("Last");
        strStack.Push("Mid");
        strStack.Push("Top");
        Console.WriteLine(strStack.Peek());

        Console.WriteLine("Int Stack: ");
        Stack<int> intStack = new Stack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);
        Console.WriteLine(intStack.Peek());

        Console.WriteLine("Int Queue: ");
        Queue<int> intQueue = new Queue<int>();
        intQueue.Enqueue(10);
        intQueue.Enqueue(20);
        Console.WriteLine(intQueue.Peek());

        LinkedList<int> list = new LinkedList<int>();
        list.AddFirst(1);

        Console.WriteLine("Collection: ");

        MyGenCollection<int> intCollection = new MyGenCollection<int>();
        intCollection.Add(10);
        intCollection.Add(20);
        int indexZeroElement = intCollection.GetElement(0);
        Console.WriteLine(indexZeroElement);
        int Length = intCollection.GetLength();
        Console.WriteLine(Length);

        MyGenCollection<Student1> studentCollection = new MyGenCollection<Student1>();
        studentCollection.Add(new Student1 { firstName = "Umeed" });
        studentCollection.Add(new Student1 { lastName = "Chandel" });
        var student = studentCollection.GetElement(0);
        Console.WriteLine(student.firstName);
        Console.WriteLine(student.lastName);

        MyGenCollection<Student2> studentCollection1 = new MyGenCollection<Student2>();

        MyGenCollection<Employee> studentCollection2 = new MyGenCollection<Employee>();
        studentCollection2.Add(new Employee());
        //studentCollection2.Add(new Student()); //compile time type checking






    }
}