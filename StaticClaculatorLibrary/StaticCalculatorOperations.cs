using System;

namespace StaticClaculatorLibrary
{
    public static partial class StaticCalculatorOperations
    {

        public static int result = 0; //read write

        public static int resultProperty { get; set; } //readonly only

        static StaticCalculatorOperations() { } //default const which static class can only have one of
        public static int Addition(int a, int b)
        {
            return a + b;
        }


        public static int Subtract(int a, int b)
        {
            int c = a - b;
            return c;
        }

    }

    public static partial class StaticCalculatorOperations
    {
        public static int Division(int a, int b)
        {
            int c = a / b;
            return c;
        }
    }


}
