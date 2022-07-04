using System.Collections.Generic;

/*GENERIC 
Define solution once, independent of data type
No Boxing & Unboxing, No Explicit Casting 
Ensure Type-Safety at Compile time
Can't assign one version to other */


namespace GenericClassLibrary
{
    public class Gen
    {
        int t;
        public Gen(int i)
        {
            this.t = i;
        }

        public void GetTypes()
        {
            Console.WriteLine("TYPE t: " + t.GetType());
            Console.WriteLine(" ");
        }

        public void GetValues()
        {
            Console.WriteLine("Value t: " + t.ToString());
            Console.WriteLine(" ");
        }
    }

    public class Gen1<T> where T : struct
    {
        public void Add(T x,T y)
        {
            //can't exp convert T into int
            dynamic a = x;
            dynamic b = y;
            Console.WriteLine(a+b);
        }
        public void Multiply(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            Console.WriteLine(a * b);
            Console.WriteLine(" ");
        }
    }

    public class Gen2<T, V>
    {
       
        public void GetName(T name)
        {
            Console.WriteLine("Name: " + name);
        }

        public void GetId(V id)
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine(" ");
        }
    }

    public class Gen3<X, Y, Z>
    {
        X x;
        Y y; 
        Z z;
        public Gen3(X x, Y y, Z z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void GetTypes()
        {
            Console.WriteLine("TYPE x: " + x.GetType());
            Console.WriteLine("TYPE y: " + y.GetType() );
            Console.WriteLine("TYPE z: " + z.GetType());
            Console.WriteLine(" ");
        }

        public void GetValues()
        {
            Console.WriteLine("Value x: " + x.ToString());
            Console.WriteLine("Value y: " + y.ToString());
            Console.WriteLine("Value z: " + z.ToString());
        }
    }
}
