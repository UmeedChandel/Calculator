namespace ClassLibrary
{
    public static class Class1
    {
        //Extenxion Method
        public static int Square(this int a)
        {
            Console.Write("Square of {0} is: ", a);
            return a * a;
        }
    }
    public class Class2
    {
        //static const readonly
        public static int staticNumber;

        public const int Age = 21;

        public readonly string name = "Umeed";

        public Class2(string rename)
        {
            //setting value of readonly
            //only posible inside constructor
            this.name = rename;

        }
    }

    public partial class Class3
    {
        //50%
        public const string Home = "HP";
        public static readonly string Work = "MP";

        //partial method inside partial class
        //declaration
        public static partial int Add(int a, int b);
    }

    public abstract class Class4
    {
        //abstract and non abstract method
        //inside abstract class
        //base class
        public abstract int Method1(int a);
        public virtual int Method2(int a)
        {
            return a;
        }
        protected internal string Method3(string str)
        {
            return str;
        }

    }
}