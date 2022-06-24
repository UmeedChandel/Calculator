using IVariousOperationscs;
namespace InheritanceLibrary
{
    public class AA
    {
        public virtual int Divide(int a, int b)
        {
            return a / b;
        }
    }

    public class BB : AA
    {
        public override int Divide(int a, int b)
        {
            return a / (b * 2);
        }

        public void Method1()
        {
            this.Divide(1, 1);
        }


    }

    public class CC : BB
    {
        public override sealed int Divide(int a, int b)
        {
            return a / (b * 3);
        }
        //any other class after C can't cahnge Divide
    }

    public class DD : CC
    {
        public void Method2()
        {
            this.Divide(3, 1);
        }
    }

    public class ClassOne : IOneInterface, ITwoInterface
    {

        //explicit implimentation - not a class member - no access modifiers
        //imlplicit implementation - class member - need access modifiers

        int IOneInterface.func(int a)
        {
            return a * 5;
        }

        int ITwoInterface.func(int a)
        {
            return a * 10;
        }

        
        public int func2(int b)
        {
            return b * 20;
        }

        public int func3(int c)
        {
            return c * 30;
        }

        public int extrafunc(int d)
        {
            return d * 40;
        }
    }

    public class ClassTwo: ClassOne
    {
        public int Test()
        {
            //this.func(1); //Can't access
            int Rfunc2 = this.func2(2);
            int Rfunc3= this.func3(3);
            int Rexfunc= this.extrafunc(4);

            Console.WriteLine("Rfunc2: {0}", Rfunc2);
            Console.WriteLine("Rfunc3: {0}", Rfunc3);
            Console.WriteLine("Rexfunc:{0} ", Rexfunc);
            return 0;
        }

    }

    public struct OneStructure : IOneInterface, IThreeInterface
    {
        int IOneInterface.func(int a)
        {
            return a * 9;
        }
        public int func4(int d)
        {
            return d;
        }

    }

    public struct TwoStructure : ITwoInterface
    {
        int ITwoInterface.func(int a)
        {
            return a * 8;
        }

        public int func2(int b)
        {
            return b * 7;
        }

        public int func3(int c)
        {
            return c * 6;
        }
    }

}