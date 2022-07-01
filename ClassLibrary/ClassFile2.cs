using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static partial class Class3
    {
        //50%
        static Class3()
        {
            //static constructor
            //setting static members
            Work = "MA";
        }
        public static partial int Add(int a, int b)
        {
            //implementation
            return a + b;
        }
    }
    public class Class5 : Class4
    {
        //drived class
        public override int Method1(int a)
        {
            //override abs 
            return a * 10;
        }
        public override int Method2(int a)
        {
            //override virtual
            return a * 20;

        }
        protected int ProtectMethod()
        {
            //Class5 member
            //protected method
            int FuncCount = 3;
            return FuncCount;
        }

    }

}
