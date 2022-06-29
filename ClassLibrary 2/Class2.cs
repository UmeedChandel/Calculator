namespace ClassLibrary
{
    public partial class ClassOne
    {
        public static partial int Add(int a, int b)
        {
            return a + b;
        }
        public partial int Subtract(int a, int b)
        {
            return a - b;
        }
        public void Extra()
        {
            Console.WriteLine("Okay! ");
        }
    }

    public delegate int OpDelegate(int a, int b);
    public delegate void OpDelegate1();
}
