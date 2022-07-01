/* Implicitly typed variable
Declaration needs initalization
built-in, user-defined, anonymous type */

var count = 10;
var day = "Friday";
var balance = 19837982.320;

Console.WriteLine("The var {0} is {1} type", count, count.GetType().ToString());
Console.WriteLine("The var {0} is {1} type", day, day.GetType().ToString());
Console.WriteLine("The var {0} is {1} type", balance, balance.GetType().ToString());
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

for(int i = 0; i < anonymousType3.Length; i++)
{
    Console.WriteLine("Name {0} : {1} {2}",i,anonymousType3[i].firstname, anonymousType3[i].lastname);
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

