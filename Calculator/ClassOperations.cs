using System;

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
    }
}
