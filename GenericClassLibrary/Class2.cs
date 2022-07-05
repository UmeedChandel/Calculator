using System.Collections.Generic;

/*T = TYPE
Class Product<T>
Interface IProduct<T>
Delegate T ProductDel<T>(T t)
Struct ProductType<T>
bool Compare<T>(T source,T target)
*/


namespace GenericClassLibrary
{
    /*Constraints for Generic
        Base class- Where T:<base class name>
        Interface- Where T:<interface name>
        Constructor- Where T:new()
        Value Type- Where T:struct
        Reference Type- Where T:class */


    public class GenForBaseClassType<T> where T : Car
    {
        Stack<T> stack = new Stack<T>();

        public void Add(T element)
        {
            stack.Push(element);
        }

        public T GetElement()
        {
            return stack.Peek();
        }

        public void Delete()
        {
            stack.Pop();
        }
    }
    public class GenForInterfaceType<T> where T : IProduct
    {

    }
    public class GenForContructorType<T> where T : new()
    {

    }
    public class GenForValueType<T> where T : struct
    {

    }
    public class GenForReferenceType<T> where T : class
    {

    }


    /* classes interfaces enum */
    public abstract class AbsProduct
    {
        public abstract void Method1();
    }
    public interface IProduct
    {
        public void Method2();

    }

    public class Product : AbsProduct, IProduct
    {
        public override void Method1()
        {
            Console.WriteLine("Inside Abstract class!");
        }

        public void Method2()
        {
            Console.WriteLine("Inside Interface member!");
        }

        public virtual void Method3()
        {
            Console.WriteLine("Car is a product!");
        }
    }

    public class Car : Product
    {
        public string carColor { get; set; }
        public override void Method3()
        {
            Console.WriteLine("Car works fine!");
        }
    }

    public enum color
    {
        red
    }

    public interface IStudent
    {

    }
    public class Student1 : IStudent
    {
        public Student1()
        {

        }

        public Student1(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }
    public class Student2 : IStudent { }
    public class Employee { }

    public class MyGenCollection<T> where T : new()
    {
        List<T> myArray = new List<T>();

        public void Add(T element)
        {
            myArray.Add(element);
        }

        public T GetElement(int index)
        {
            return myArray.ElementAt(index);
        }

        public void topHeighest()
        {
            myArray.Sort();
            myArray.Reverse();
        }

        public int GetLength()
        {
            return myArray.Count;
        }

    }

}
