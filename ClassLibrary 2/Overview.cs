using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverAll
{
    //this is your interface scope
    //struct, enum, class, interface, delegate

    //instance class
    //access modifers - public, private, protected, internal, protected internal - Encapsulation
    public class InstanceArithmeticOperations
    {
        //fields
        //properties
        //constructor
        //destructor
        //methods
        //events
        //indexers
        //other types


        //default contructor - InstanceArithmeticOperations operations = new InstanceArithmeticOperations()
        //overloading is possible - order of parameters, number of parameters, type of parameters
        public InstanceArithmeticOperations()
        {

        }


        //instance member
        //method signature - return type and parameters
        public int Add(int a, int b)
        {
            return a + b;
        }

        //instance member - accessible only inside assembly/project
        internal int Subtract(int a, int b)
        {
            return a - b;
        }

        //class member
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        //default implementation - this is called Polymorphism
        public virtual int Divide(int a, int b)
        {
            return a / b;
        }

    }


    //static class - maintains only copy in memory, methods can be invoked by classname, all members should be static
    public static class StaticArithmeticOperations
    {

        //static contructor, no modifiers allowed, no parameters allowed, no overloading, initialize static properties or fields, invoked when calling first static member
        static StaticArithmeticOperations()
        {

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }


        internal static int Subtract(int a, int b)
        {
            return a - b;
        }

        //class member
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        //default implementation
        public static int Divide(int a, int b)
        {
            return a / b;
        }

    }

    //partial class, should use partial keyword, inside one file or many files, should be under common namespace, instance class, methods can be invoked by object
    //part 1
    public partial class PartialArithmetic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        //partial methods - can be inside partial class, divide definition and implementation, partial keyword must, can be static but not virtual
        public partial int PartialMethodDivide(int a, int b);
    }

    //part 2
    public partial class PartialArithmetic
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        //partial method cannot be virtual
        public partial int PartialMethodDivide(int a, int b)
        {
            return a / b;
        }
    }

    //this is Data abstraction
    public abstract class AbsArithmeticOperations
    {
        //can have contructors
        public AbsArithmeticOperations()
        {

        }

        //abstract method
        public abstract int Add(int a, int b);

        //abstract method
        public abstract int Subtract(int a, int b);

        //normal method
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        //virtual method
        public virtual int Divide(int a, int b)
        {
            return a / b;
        }

        public static int SquareRoot(int a)
        {
            return a * a;
        }
    }


    //Interface keyword, no implementation, start with "I", cannot create object but can declare object, implicity/explicit implementation, 
    //all the members are implicitly public
    //implicit - both interface and class member
    //explicit - they are only interface member, cannot access by class object, you can assign the object to interface object can invoke the method
    //filter - if you assign class object to interface, only interface members can be accessible.
    //supports muliple inheritance - one interface can inherit from another, or more.

    public interface IArithmeticOperations
    {
        //ProEMI
        //Properties
        //Events
        //Methods
        //Indexers

        //default methods possible from C# 8
        public void DefaultMessage()
        {
            Console.WriteLine("Hey GL!!");
        }


        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        int Divide(int a, int b);
    }

    //structs are value types, stored in stack member, no inheritance support, but can inherit interfaces, can be invoked without new operator
    //ArithmeticStruct structObject;
    //ArithmeticStruct structObject = new ArithmeticStruct(); - constuctor will get called
    public struct ArithmeticStruct
    {
        //all class members you can define here.
        public ArithmeticStruct()
        {

        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    //enum are value types, string constants
    public enum Days
    {
        Monday,
        Thusday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    //Delegates are function pointers
    //Delegate are reference types - create object with new operator
    //During object creation, you can pass your method name as parameter => ArithmeticDelegate delObject = new ArithmeticDelegate(StaticArithmeticOperations.Add)
    //can be invoked by - delObject(10,10);
    //can store multiple method addresses - it is called multi casting
    //Delegates are type safe - method signature must match with delegate signature

    //Anonymous methods can be created on the fly => delegate(int a, int b){ return a+b;};

    public delegate int ArithmeticDelegate(int a, int b);

    //boxing - conversion from value to reference type => Object o = i;
    //Unboxing - conversin from reference type to value type => i = (int)o;   


    //nullable types
    //int i = 0;
    //int i = null; //throws error
    //int? i = null; // this is called nullable type. you can make your value types are null supported


    //Extension methods
    //static methods inside static class,
    //first parameter with "this" keyword - this is the extension method for this type
    //you can attach any custom method to any predefined or user defined types - int, float, string, Student - (Struct, Class or Interfaces)
    public static class Extensions
    {
        public static int squareRoot(this int number)
        {
            return number * number;
        }
    }


    public class Overview
    {
        //Exception handling
        public void testMethod()
        {
            //try and catch block
            try
            {
                //try and finally block
                try
                {
                    //multiple catch blocks
                    try
                    {
                        //try, catch and finally block
                        try
                        {
                            //try, multiple catch and finally block
                            try
                            {
                                int i = 0;
                                int? j = null;
                                int k = 5;
                                int result = k.squareRoot();

                            }
                            catch (FormatException formatEx)
                            {

                                throw;
                            }
                            catch (Exception)
                            {

                                throw;
                            }

                            finally
                            {

                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        finally
                        {

                        }
                    }
                    catch (FormatException formatEx)
                    {

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
                finally
                {

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

//Happy Coding Guys.............
