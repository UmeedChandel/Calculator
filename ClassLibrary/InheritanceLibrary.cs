namespace InheritanceLibrary
{

    public class AA
    {
        public virtual int Divide(int a,int b)
        {
            return a/b;
        }
    }

    public class BB : AA
    {
        public override int Divide(int a, int b)
        {
            return a / (b*2);
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
            return a / (b*3);
        }
        //any other class after C can't cahnge Divide
    }

    public class DD : CC
    {
        public void Method2()
        {
            this.Divide(3,1);           
        }
    }
}