using System;
using System.Collections.Generic;
using System.Text;
using Calculator;

namespace AccessModifiers
{
    public class AccessModOp1
    { 
        public int Operation1(int a)
        {
            int c = a + a;
            return c;
        }

        private int Operation2(int a,int b)
        {
            int c = a + b;
            return c;
        }

        protected int Operation3(int a,int b,int c)
        {
            c = a + b + c;
            return c;
        }

        internal int Operation4(int a , int b, int c, int d)
        {
            d= a + b + c + d;
            return c;
        }

        protected internal int Operation5(int a, int b)
        {
            int d = a + b;
            return d;
        }
    }

    public class AccessModOp2: AccessModOp1
    {
        public int invoke1()
        {
            Console.WriteLine("It's Invoke 1 Namespace A (IN)");
            this.Operation1(10); //public
            //this.Operation3(10, 10); //private
            this.Operation3(10, 10, 10); //protected
            this.Operation4(10, 10, 10, 10); //internal
            this.Operation5(10, 10); //protected internal
            return 0;
        }
    }

    public class AccessModOp3
    {
        public int invoke2()
        {
            Console.WriteLine("It's Invoke 2 Namespace A (IX)");
            AccessModOp1 obj = new AccessModOp1();
            obj.Operation1(20); //public
            //obj.Operation3(20, 20); //private
            //obj.Operation3(20, 20, 20); //protected
            obj.Operation4(20, 20, 20, 20); //internal
            obj.Operation5(20, 20); //protected internal

            return 0;
        }
    }
}
