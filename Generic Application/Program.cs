using GenericClassLibrary;
using System.Collections.Generic;
using System.Collections;
using Aardvark.Base;
using System;

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

        GenForBaseClassType<Car> productVersionOfGen = new GenForBaseClassType<Car>(); ;

        GenForInterfaceType<IProduct> genForInterfaceType = new GenForInterfaceType<IProduct>();
        GenForContructorType<Car> carVersionOfGen = new GenForContructorType<Car>();

        GenForValueType<int> intGenWithContraint = new GenForValueType<int>();
        GenForValueType<color> genForValueType = new GenForValueType<color>();

        GenForReferenceType<string> stringGenWithContraint = new GenForReferenceType<string>();
        GenForReferenceType<IProduct> genForReferenceType = new GenForReferenceType<IProduct>();

        //GenForValueType<string> stringObject = new GenForValueType<string>();//error, because string is not value type


        //Generic Algorithms
        Console.WriteLine(" ");
        Console.WriteLine("String Stack: ");
        Stack<string> strStack = new Stack<string>();
        strStack.Push("Last");
        strStack.Push("Mid");
        strStack.Push("Top");
        foreach (var i in strStack)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(" ");
        Console.WriteLine("Int Stack: ");
        Stack<int> intStack = new Stack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);
        Console.WriteLine(intStack.Peek());

        Console.WriteLine(" ");
        Console.WriteLine("Generic Queue: ");
        Queue<int> intQueue = new Queue<int>();
        intQueue.Enqueue(10);
        intQueue.Enqueue(20);
        Console.WriteLine(intQueue.Peek());

        Console.WriteLine(" ");
        Console.WriteLine("Non Generic Queue: ");
        Queue queue = new Queue();
        queue.Enqueue(10);
        queue.Enqueue("GL");
        queue.Enqueue(1);
        queue.Enqueue(100);
        queue.Enqueue(2.4);
        queue.Enqueue(20);
        foreach (var i in queue)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(" ");
        Console.WriteLine("Collection LIST: ");

        MyGenCollection<int> intCollection = new MyGenCollection<int>();
        intCollection.Add(10);
        intCollection.Add(25);
        intCollection.Add(5);
        intCollection.Add(87);
        intCollection.Add(3);
        intCollection.Add(50);
        intCollection.topHeighest();
        int topthirdelement = intCollection.GetElement(2);
        Console.WriteLine("Top Third Element: ");
        Console.WriteLine(topthirdelement);

        MyGenCollection<Student1> studentCollection = new MyGenCollection<Student1>();
        studentCollection.Add(new Student1 { firstName = "Umeed" });
        studentCollection.Add(new Student1 { lastName = "Chandel" });
        var student = studentCollection.GetElement(0);
        Console.WriteLine(student.firstName);
        Console.WriteLine(student.lastName);

        MyGenCollection<Student2> studentCollection1 = new MyGenCollection<Student2>();
        studentCollection1.Add(new Student2());

        MyGenCollection<Employee> studentCollection2 = new MyGenCollection<Employee>();
        studentCollection2.Add(new Employee());


        Console.WriteLine("Collection Linked LIST: ");

        MyGenLinkedCollection<int> LinkedCollection = new MyGenLinkedCollection<int>();
        LinkedCollection.Add(10);
        LinkedCollection.Add(25);
        LinkedCollection.GetAllElement();
        Console.WriteLine(" ");

        MyGenLinkedCollection<string> LinkedCollection1 = new MyGenLinkedCollection<string>();
        LinkedCollection1.Add("My");
        LinkedCollection1.Add("Name");
        LinkedCollection1.Add("is");
        LinkedCollection1.Add("LinkedCollection");
        LinkedCollection1.GetAllElement();
        Console.WriteLine(" ");
        Console.WriteLine("Removed 1st element");
        LinkedCollection1.Remove();
        LinkedCollection1.GetAllElement();

        MyGenLinkedCollection<Employee> LinkedCollection2 = new MyGenLinkedCollection<Employee>();
        LinkedCollection2.Add(new Employee());

        Console.WriteLine(" ");
        Console.WriteLine("Collection Stack: ");
        GenForBaseClassType<Car> stackCollection = new GenForBaseClassType<Car>();
        stackCollection.Add(new Car { carColor = "Red" });
        stackCollection.Add(new Car { carColor = "Blue" });
        stackCollection.Add(new Car { carColor = "Green" });
        var car = stackCollection.GetElement();
        Console.WriteLine(car.carColor);
    }

    

}