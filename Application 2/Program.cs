// See https://aka.ms/new-console-template for more information
using ClassLibrary;

ClassOne partialObject = new ClassOne();
int Answer1 = partialObject.Subtract(20, 10);//instance partial method, so called by object
int Answer2 = ClassOne.Add(10, 10);//static partial method, so called by class name

Console.WriteLine("Partial Class and Method: ");
Console.WriteLine("Answer for instance method {0} and static method {1}",Answer1,Answer2);

Console.WriteLine(" ");
Console.WriteLine("Delegate and Anonymous method: ");
ClassOne classObject = new ClassOne();
OpDelegate delegateObject = new OpDelegate(ClassOne.Add);
OpDelegate delegateObject1 = new OpDelegate(classObject.Subtract);

int result1 = delegateObject(40, 20);
int result2 = delegateObject1(40, 20);
Console.WriteLine(result1);
Console.WriteLine(result2);

OpDelegate1 delegateObject2 = new OpDelegate1(classObject.Extra);
int a = 20, b = 30;
delegateObject2 += delegate ()
{
    Console.WriteLine("Anonymous Multiply: {0}", a * b);
};
delegateObject2();

Console.WriteLine(" ");
Console.WriteLine("Boxing and Unboxing: ");

/* Boxing
conversion from value type to reference type */

int x = 10;
object o = x;

Console.WriteLine("Boxing Object {0}",o);

/* Unboxing
reverse process conversion from reference type to value type */

int y = (int)o;
//need to tell explicitly what type of data 
//is already therr inside the box

Console.WriteLine("Unboxing Y {0}", y);

/* Nullable type
referance type can store null values by default */

string str1 = "Hello";
string str2 = null;
ClassOne Object; //~null

//int k = null; //can't be null
int? k = null; //now can be null

//convert value type to nullable type by adding "?"

double? d = null;

if (d.HasValue)
{
    Console.WriteLine(d);
}
d.GetValueOrDefault();
//either give me the value
//if no value give default value
//don't throw error


Console.WriteLine(" ");
Console.WriteLine("Extension Method: PART 1 ");

int i = 10;
int resultofExtMethod = i.Square();
Console.WriteLine(resultofExtMethod);

string str = "Global";
Console.WriteLine(str.ConcatExtension("Logic"));

int t1 = 12;
Console.WriteLine(t1.Table());
Console.WriteLine(" ");
int t2 = 21;
Console.WriteLine(t2.Table());


Console.WriteLine(" ");
Console.WriteLine("Extension Method: PART 2 ");

char var1 = 'u';
string statement1 = "My name is Umeed. What is your name! Huh?";
Console.WriteLine(statement1.CountChar(var1));

int num1 = 6;
Console.WriteLine(num1.EvenOrNot());

