namespace InheritanceLibrary
{

    public class A
    {
        public virtual int Divide(int a,int b)
        {
            return a/b;
        }
    }

    public class B : A
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

    public class C : B
    {
        public override sealed int Divide(int a, int b)
        {
            return a / (b*3);
        }
        //any other class after C can't cahnge Divide
    }

    public class D : C
    {
        public void Method2()
        {
            this.Divide(3,1);           
        }
    }
}