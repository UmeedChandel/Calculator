using System;
using System.Collections.Generic;
using System.Text;

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
}