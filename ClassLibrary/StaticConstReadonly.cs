
namespace StaticConstReadonly
{
    public class A
    {
        //FIELDS

        public static int staticNumber;
        /*static field
         class member
         call by class name */

        public const int constNumber = 21;
        /*constant field
         aslo class member 
         initialize when declare
         can't change immutable */

        public readonly string name = "Cool";
        /*readonly fields
         can't be set class
         can use constructor */

        public A(string rename)
        {
            //setting value to readonly feild inside constructor
            //invokes when object is creacted
            this.name = rename;
        }


        public const string Team1 = "A";
        public static readonly string Team2 = "B";

        static A()
        {
            /*static constructor
              initialize static members 
              no parameter
              only one 
              */
            Team2 = "C";

            //when static member gets call it will incoke static constructor
        }

    }

    public class B
    {
        A a = new A("Very Cool");
        A b = new A("Not Cool");

        public int Test()
        {
            A.staticNumber = 10;

            int display = A.constNumber;

            string display1 = a.name; // output: Vey Cool
            string display2 = b.name; // Output: Not Cool

            string teamAllocation1 = A.Team1;
            string teamAllocation2 = A.Team2;

            //a.name = "Not allowed"; //restricted

            Console.WriteLine("Constant: " + display);
            Console.WriteLine("Readonly 1: " + display1);
            Console.WriteLine("Readonly 2: " + display2);
            Console.WriteLine("Contant: " + teamAllocation1);
            Console.WriteLine("Static Readonly: " + teamAllocation2);

            return 0;
        }

    }

}
