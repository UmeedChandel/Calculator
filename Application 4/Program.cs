/* Implicitly typed variable
Declaration needs initalization
built-in, user-defined, anonymous type */

//var check during compilation
//dynamic check during run time
//DLR (Dynamic Lang Runtime)on top of CLR

Console.WriteLine("Dynamic Keyword: ");
dynamic day = 11;
//dynamic day = "Monday";
dynamic balance = 19837982.320;

//Console.WriteLine("The dynamic {0} is {1} type", day, day.GetType());
Console.WriteLine("The dynamic {0} is {1} type", day, day.GetType());
Console.WriteLine("The dynamic {0} is {1} type", balance, balance.GetType());
Console.WriteLine(" ");

var count = 10;
var day1 = "Friday";
var balance1 = 19837982.320;

Console.WriteLine("The var {0} is {1} type", count, count.GetType().ToString());
Console.WriteLine("The var {0} is {1} type", day1, day1.GetType().ToString());
Console.WriteLine("The var {0} is {1} type", balance1, balance1.GetType().ToString());
Console.WriteLine(" ");

for (var x = 0; x < 4; x++)
{
    Console.WriteLine("var value: {0}", x);
}
Console.WriteLine(" ");

/* Anonymous Type
type class without name
create obj with new 
only public read only properties
can be nested, array */

//type(class) without name
//only public readonly properties allowed in anonymous type
Console.WriteLine("Anonymous type(class) ");
var anonymousType = new { firstname = "umeed", lastname = "chandel" };
Console.WriteLine("The var object lastname is {0}", anonymousType.lastname);
Console.WriteLine(" ");

var contact = 1234567890;

//nested
var anonymousType1 = new
{
    firstname = "umeed",
    lastname = "chandel",
    address = new { city = "Jabalpur", State = "MP" },
    contact
};
Console.WriteLine("Anonymous nested");
Console.WriteLine("Nmae: {0} {1}, Contact: {2}, Address: {3} {4}", 
    anonymousType1.firstname, anonymousType1.lastname, anonymousType1.contact, 
    anonymousType1.address.city, anonymousType1.address.State);
Console.WriteLine(" ");

//array
//maintain same number and order of properties
var anonymousType2 = new[]
{
    new { firstname = "umeed" , lastname = "chandel" },
    new { firstname = "tulika" , lastname = "jain" },
    new { firstname = "priyansh" , lastname = "verma" }
};
Console.WriteLine("Anonymous Array 0 : {0} {1}",
    anonymousType2[0].firstname, anonymousType2[0].lastname);
Console.WriteLine(" ");

//nested and array
var anonymousType3 = new[]
{
    new
    {
        firstname = "umeed",
        lastname = "chandel",
        address = new { city = "jabalpur", State = "MP" }
    },
    new
    {
        firstname = "shreya",
        lastname = "patel",
        address = new { city = "rewa", State = "MP" }
    },
    new
    {
        firstname = "pragya",
        lastname = "agarawal",
        address = new { city = "keolari", State = "MP" }
    }
};

for (int t = 0; t < anonymousType3.Length; t++)
{
    Console.WriteLine("Name {0} : {1} {2}", t, anonymousType3[t].firstname, anonymousType3[t].lastname);
}
Console.WriteLine(anonymousType2.GetType().ToString());
Console.WriteLine(" ");

//object initialization
Console.WriteLine(" Objects ");
var studentObject = new student();
Console.WriteLine(studentObject.GetType().ToString());

var studentObject1 = new student() { firstname = "umeed", lastname = "chandel" };
var studentFirstName = new student { firstname = "umeed" };
var studentLastName = new student { lastname = "chandel" };

//array initialize with object
//no need to maintain no. or order of properties
student[] students = new student[] {
    new student {firstname = "", lastname = ""},
    new student {firstname = "", lastname = ""}
};
Console.WriteLine(students.GetType().ToString());

//value and reference types:
//possible to cast string to object both are reference types

int[] numberss = { 10, 20 };
//object[] objectNumbers = numberss; // not possible to cast int[] to object[]

string[] names = { "A", "B" };
object[] objects = names; // possible to cast string[] to object[], both are reference types
Console.WriteLine(" ");
Console.WriteLine("cast string[] to object[]: ");
Console.WriteLine(objects[0] + " " + objects[1]);

//Compile time - eorror
//Run time - exception

int? i = null;
Nullable<int> i1 = null;
int j = i ?? 0;

int? nullableResult = i + j;
int nonnullableResult = (i + j) ?? 0;

Console.WriteLine(" ");
if (i.HasValue)
{
    Console.Write("Has value or not: " + i);
}

Console.WriteLine("NUM: ");
var num = new int[] { 1, 3, 5 ,3 ,6 ,4, 2 };
foreach(var a in num)
{
    Console.Write(a + ", ");
}

//avoid indexing
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("System.Linq Liberary Func: ");
Console.WriteLine(" ");
Console.WriteLine("First " + num.First());
Console.WriteLine("With Default " + num.FirstOrDefault());
Console.WriteLine("Last " + num.Last());
Console.WriteLine("With Default " + num.LastOrDefault());
Console.WriteLine("Element At " + num.ElementAt(2));
Console.WriteLine("Or Default " + num.ElementAtOrDefault(2));

try
{ Console.WriteLine(num.Single()); }
catch (Exception ex)
{ Console.WriteLine("Exception: " + ex.Message); }

try
{ Console.WriteLine(num.SingleOrDefault()); }
catch (Exception ex)
{ Console.WriteLine("Exception: " + ex.Message); }

//avoid duplicate
Console.WriteLine(" ");
Console.WriteLine("Distinct: ");
var distinctNum = num.Distinct();
foreach (var n in distinctNum)
{
    Console.Write(n +", "); 
}

Console.WriteLine(" ");
Console.WriteLine("Aggregate Function: ");

Console.WriteLine("Sum " + num.Sum());
Console.WriteLine("Avg " + num.Average());
Console.WriteLine("Count " + num.Count()); //method
Console.WriteLine("Length " + num.Length); //property

//when it go beyond int32
Console.WriteLine("Long Count " + num.LongCount());
Console.WriteLine("Long Length " + num.LongLength);

Console.WriteLine("Max " + num.Max());
Console.WriteLine("Min " + num.Min());

Console.WriteLine("Contains " + num.Contains(6));

Console.WriteLine(" ");
Console.WriteLine("Concat like string but list ");
var ConcatNum = num.Concat(new int[] { 6,8,9 });
foreach (var n in ConcatNum)
{
    Console.Write(n + ", ");
}

Console.WriteLine(" ");
//lambda
var var1 = num.Aggregate((a,b)=>a+b);
Console.WriteLine("Lambda Aggregate "+var1);

var num2 = ConcatNum.Concat(new int[] {10,0});

Console.WriteLine(" ");
Console.WriteLine("Union: ");
var var2 = num.Union(num2);
foreach(var o in var2)
{ Console.Write(o + ", "); }

Console.WriteLine(" ");
Console.WriteLine("Intersect: ");
var var3 = var2.Intersect(new int[] {4,3});
foreach(var p in var3)
{ Console.Write(p + ", "); }

Console.WriteLine(" ");
Console.WriteLine("Except: ");
var var4 = var2.Except(new int[] {1,7});
foreach(var k in var4)
{ Console.Write(k + ", "); }

Console.WriteLine(" ");
Console.WriteLine("Take: ");
var var5 = var2.Take(4);
foreach (var n in var5)
{ Console.Write(n + ", "); }

Console.WriteLine(" ");
Console.WriteLine("Skip: ");
var var6 = var2.Skip(4);
foreach (var b in var6)
{ Console.Write(b + ", "); }

Console.WriteLine(" ");
Console.WriteLine("Range ");
var var7 = Enumerable.Range(20,10);
foreach (var f in var7)
{ Console.Write(f + ", "); }

Console.WriteLine(" ");
Console.WriteLine("Repeat ");
var var8 = Enumerable.Repeat(10,5);  
foreach (var d in var8)
{ Console.Write(d + ", "); }

// takewhile skipwhile takelast skiplast
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("TakeWhile ");
var var9 = num.TakeWhile(num => num >= 3);
foreach (var f in var9)
{ Console.Write(f + ", "); }

Console.WriteLine(" ");
Console.WriteLine("SkipWhile ");
var var10 = num.SkipWhile(num => num <= 3);
foreach (var f in var10)
{ Console.Write(f + ", "); }

Console.WriteLine(" ");
Console.WriteLine("Takelast ");
var var11 = num.TakeLast(2);
foreach (var f in var11)
{ Console.Write(f + ", "); }

Console.WriteLine(" ");
Console.WriteLine("SkipLast ");
var var12 = num.SkipLast(3);
foreach (var f in var12)
{ Console.Write(f + ", "); }
Console.WriteLine(" ");
Console.WriteLine(" ");

Console.WriteLine("=======List Query======");

List<int> numbers = new() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

int countNum = 0;
numbers.Sort();
var NumQuery1 = numbers.Where(n => (n < 3 || n > 8));
Console.WriteLine(" ");
Console.WriteLine("1. filter the number < 3 and >8: ");
foreach (var item in NumQuery1)
{
    Console.Write(item + " ");
    countNum++;
}
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("2. how many numbers are <3 and > 8 in above lists: " + countNum);

Console.WriteLine(" ");
Console.WriteLine("3. find out all the even numbers: ");
var NumQuery2 = numbers.Where(num => num % 2 == 0);
foreach (var item in NumQuery2)
{
    Console.Write(item + " ");
}
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Sorted List ");
numbers.Sort();
foreach (var item in numbers)
{
    Console.Write(item + " ");
}

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("4. find the 3rd highest: {0}  and 4th lowest: {1}",
    numberss.TakeLast(3).FirstOrDefault(),
    numberss.Skip(3).FirstOrDefault());


class student
{
    //all types supported
    public string firstname { get; set; }
    public string lastname { get; set; }

    class Address
    {
        //all types supported
        //outer.inner obj = new outer.inner();
        public string city { get; set; }
        public string state { get; set; }
    }
}

