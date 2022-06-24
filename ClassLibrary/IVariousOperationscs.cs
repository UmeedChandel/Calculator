/*contract b/w entities (all or none)
  members are all public
  no implementation inside
  implemented inside class/struct
  support Properties, methods, events, indexers
  support multiple inheritance also*/

namespace IVariousOperationscs
{
    public interface IOneInterface
    {
        int func(int a);
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


}
