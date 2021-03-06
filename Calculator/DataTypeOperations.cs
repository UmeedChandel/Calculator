using System;
using System.Collections.Generic;
using System.Text;
using Calculator;

namespace structLiberary
{
    public struct Complex1  
    {
        // no inheritance
        // struct to struct inheretance is prohibited
        // struct can inherit interface
        // but not classes

        public float Addition(float a, float b)
        {
            Console.Write("Adding Float: ");
            float c = a + b;
            return c;
        }

        public double Subtract(double a, double b)
        {
            Console.Write("Subtracting Double: ");
            double c = a - b;
            return c;
        }

        public decimal Multiply(decimal a, decimal b)
        {
            Console.Write("Multiplying Decimal: ");
            decimal c = a * b;
            return c;
        }
    }

    public class Complex2
    {
        public int AddMethod(int a, int b)
        {
            return a + b;
        }

        public int SubtractMethod(int a, int b)
        {
            return a - b;
        }

        public void Method(int a)
        {
            Console.WriteLine("Void Method 1st a: {0}", a);
        }
        public static void Method1(int a)
        {
            Console.WriteLine("Void Method 2nd b: {0}", a);
        }
    }

    public enum Complex3 { Umeed, Palak, Aishwarya, Aman }

    /*DELEGATE
      reference type complex data type
      they are func/method pointer
      store your method address
      method & delegate signature match
      Delegates are type safe */

    public delegate int ItsDelegate(int exp1, int exp2);
    public delegate void ItsDelegate1(int exp1);

    /*
     
     Action Delegate - wont return any value(16para)
   
        public delegate void Action<in T>(T obj);
   
    Perdicate Delegate -accept para return boolean
    
        public delegate bool Predicate<in T>(T obj);
    Function Delegate - accept para(16) return value(1)
   
        public delegate void Function<in T>(T obj); 
    
     */
   


}