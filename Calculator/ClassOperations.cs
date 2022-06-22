using System;
using AccessModifiers;

namespace Calculator
{
    public class ClassOperations
    {
        public int Addition(int a)
        {
            int c = a + a;
            return c;
        }
        public int Addition(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public int Addition(int a, int b,int c)
        {
            int d = a + b+ c;
            return d;
        }

        public int Subtract(int a, int b)
        {
            int c = a - b;
            return c;
        }

        public int Subtract(int a, int b, int c)
        {
            int d = a - b - c;
            return d;
        }

        public int Division(int a, int b)
        {
            int c = a / b;
            return c;
        }

        public int Division(int a, int b, int c)
        {
            int d = a / b;
            int e = c / d;
            return e;
        }


        public int Multiplication(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public int Multiplication(int a)
        {
            int c = a * a;
            return c;
        }

        public int invoke4()
        {
            AccessModOp1 am = new AccessModOp1();
            Console.WriteLine("It's Invoke 4 Namespace B ");
            am.Operation1(40); //public
            //am.Operation3(40, 40); //private
            //am.Operation3(40, 40, 40); //protected
            am.Operation4(40, 40, 40, 40); //internal
            am.Operation5(40, 40); //protected internal


            return 0;
        }
    }

    public class ClassOperations1: AccessModOp2
    {
        public int invoke3()
        {
            Console.WriteLine("It's Invoke 3 Namespace B (IX) ");
            this.Operation1(30); //public
            //this.Operation3(30, 30); //private
            this.Operation3(30, 30, 30); //protected
            this.Operation4(30, 30, 30, 30); //internal
            this.Operation5(30, 30); //protected internal


            return 0;
        }

    }
}
