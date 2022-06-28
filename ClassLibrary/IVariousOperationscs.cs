/* INTERFACES
  contract b/w entities (all or none)
  members are all public
  no implementation inside
  implemented inside class/struct
  support Properties, methods, events, indexers
  support multiple inheritance also*/

namespace IVariousOperationscs
{
    public interface IOneInterface
    {
        //implicitly abstract & access mod not require
        int func(int a);
        static int func0(int a)
        {
            return a;
        }
        //interface defult method, interface member
        int func1(int a)
        {
            return a;
        }
    }
    public partial interface ITwoInterface
    {
        int func(int a);
        int func2(int b);
    }

    public partial interface ITwoInterface
    {
        int func3(int c);
    }

    //Interfaces can inherit interfaces
    public partial interface IThreeInterface: IOneInterface 
    {
        int func4(int d);
    }

    /* ABSTRACT CLASS
       both abstract(no implementation) and non abstract(default implementation)
       cannot creat object beacause we don't have functionality for some methods
       only one abstarct method can make the whole class abstract
       abstract member must be override
       sealed not allowed (should not restrict inheritance thats the purpose of)*/
    public abstract class AbsOperations //base class
    {
        //explicitly abstract & require access mod
        public abstract int AbsMethod1(int a);
        public int Method2(int a)
        {
            return a * 20;
        }
        public virtual int Method3(int a) 
        {
            return a;
        }

    }
}
