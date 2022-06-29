namespace ClassLibrary
{
    public partial class ClassOne
    {
        //can be static, virtual, sealed
        public static partial int Add(int a, int b);
        public partial int Subtract(int a, int b);

    }

    /* Extension Method
       Attach method to the datatype itself (1st para "this")
       should be a static method inside a static class */

    public static class ExtensionMethod
    {
        public static int Square(this int i)
        {
            return i * i;
        }

        public static string ConcatExtension(this string str, string str2)
        {
            return str + " " + str2;
        }

        public static int Table(this int i)
        {
            int a = 1;
            Console.WriteLine("Table of {0}",i);
            while(a<=10)
            {
                Console.WriteLine("{0} * {1} = {2}",i,a,(i * a));
                a++;
            }
            return 0;
        }

        public static int CountChar(this string str,char a)
        {
            int Count = 0;
            string smallStr = str.ToLower();
            if (!string.IsNullOrEmpty(smallStr)) 
            {
                foreach (char chr in smallStr)
                {
                    if (chr == a)
                    {
                        Count++;
                    }
                }

            }
            Console.Write("Number of char {0} are: ",a);
            return Count;
        }

        public static bool EvenOrNot(this int i)
        {
            Console.Write("Is Num Even: ");
            return (i % 2 == 0);
        }
    }
}