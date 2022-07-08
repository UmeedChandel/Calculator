﻿using System.Diagnostics.CodeAnalysis;
using System.Linq;

var num = new int[] { 1, 2, 3, 4, 3, 2, 1 };
var numbers = num.GroupBy(i => i).Where(g => g.Count() == 1).Select(k => k.Key);
Console.WriteLine("Unique: " + numbers.FirstOrDefault());

var v1 = num.All(num => num%2 == 0);
var v2 = num.Any(num => num == 3);

Console.WriteLine("All: " +v1);
Console.WriteLine("Any: " +v2);

//traditional
Student stu = new Student();
stu.Fname = "A";
stu.Lname = "B";

List<Student> stuList = new List<Student>();
stuList.Add(stu);

//object initializer
var stu1 = new Student { Fname = "", Lname = "" };

//anonymous object and initializer
var stu2 = new { Fname = "", Lname = "" };

//object and collection initializer
var stu3 = new List<Student> {
new Student {Fname= "Sriram" , Lname ="" , Age = 21 ,Gender='M'},
new Student {Fname= "Sneha" , Lname ="Sinha", Age = 22 ,Gender='F' },
new Student {Fname= "Simran" , Lname ="Singh", Age = 21 ,Gender='F' },
new Student {Fname= "Subhash" , Lname ="Gurjar", Age = 22 ,Gender='M'},
new Student {Fname= "Umeed" , Lname ="Chandel", Age = 21 ,Gender='F'}
};

//Query

Console.WriteLine("Single: " + stu3.SingleOrDefault(s => s.Fname == "Sneha").ToString());
Console.WriteLine("First : "+ stu3.FirstOrDefault().Fname);
Console.WriteLine("Last  : " + stu3.LastOrDefault().Fname);
Console.WriteLine("EleAt : " + stu3.ElementAtOrDefault(2).Fname);

var q1 = stu3.All(s => s.Age > 18);
var q2 = stu3.Any(s => s.Age > 23);

Console.WriteLine("All 18+ :" + q1);
Console.WriteLine("Any 23+ :" + q2);

Console.WriteLine("=====ConvertAll=====");
var q3 = stu3.ConvertAll(s => s.Fname + " " + s.Lname);
foreach (var i in q3)
{ Console.WriteLine(i); }

var newStu = new Student { Fname = "Mr.Rajeev", Lname = "Kumar", Age = 35, Gender = 'M' };

Console.WriteLine("=====After Append=====");
if (!stu3.Contains(newStu, new StudentEqualityComparer()))
{
    var stu4 = stu3.Append(newStu);
    foreach (var i in stu4)
    { Console.WriteLine(i.ToString()); }
    var maxAgeStudent = stu4.Max(student => student.Age);
    Console.WriteLine("Max Age Student "+ maxAgeStudent);   
}

var stu5 = new[] {
    new Student{Fname="Vaibhav",Lname="Bhatnagar",Age=21, Gender='M' },
    new Student{Fname="Pujitha",Lname="Vavilapalli",Age=21, Gender='F' },
    new Student{Fname="Palak",Lname="Soni",Age=20, Gender='F' },
    new Student{Fname="Saurabh",Lname="Kumar",Age=21, Gender='M' },
    new Student{Fname="Tisha",Lname="Varshney",Age=20, Gender='F' },
    new Student{Fname="Aman",Lname="Asati",Age=21, Gender='M' },
    new Student{Fname="Aman",Lname="Asati",Age=21, Gender='M'}
};

Console.WriteLine("=======Distinct=======");
var distinctStudents = stu5.Distinct(new StudentEqualityComparer());
foreach (var item in distinctStudents)
{
    Console.WriteLine(item.Lname);
}

Console.WriteLine("=======Concat=======");
var mithra = new Student { Fname = "Mithra", Lname = "Rajeev Kumar", Gender = 'M', Age = 6 };
var anotherStudentList = new List<Student> { mithra };
var afterConcat = stu5.Concat(anotherStudentList);
foreach (var item in afterConcat)
{
    Console.WriteLine(item.Fname);
}

//union, intersect, except

Console.WriteLine("=======Union=======");
var stu35 = stu5.Union(stu3); //stu 3 and stu 5
foreach (var i in stu35)
{ Console.WriteLine(i.Fname); }

Console.WriteLine("=======Intersect=======");
var stu335 = stu3.Intersect(stu35, new StudentEqualityComparer()); // common in stu3 and (stu3 and stu 5) = stu3
foreach (var i in stu335)
{ Console.WriteLine(i.Fname); }

Console.WriteLine("=======Except=======");
var stu35minusstu3 = stu35.Except(stu3, new StudentEqualityComparer()); // (stu3 and stu 5) - stu3 = stu5
foreach (var i in stu35minusstu3)
{ Console.WriteLine(i.Fname); }

//where, orderBy, OderByDescending, ThenBy, GroupBy, Join, Select 

Console.WriteLine("==============Where==============");

var q4 = stu35.Where(s => s.Age == 21);
Console.WriteLine("colleague with age 21");
foreach (var item in q4)
{ Console.WriteLine(item.ToString()); }

Console.WriteLine("==============OrderBy==============");

var q5 = stu35.Where(s => ((s.Age == 21 || s.Age == 22) && s.Gender == 'F')).OrderBy(s => s.Lname);
Console.WriteLine("Female colleague with age 21 or 22");
foreach (var item in q5)
{ Console.WriteLine(item.ToString()); }

Console.WriteLine("=========OrderBy Desc ThenBy=========");

var q6 = stu35.Where(s => s.Fname.StartsWith('S')).OrderByDescending(s => s.Fname).ThenBy(s => s.Age);
Console.WriteLine("Colleague 1st Name start with 'S'");
foreach (var item in q6)
{ Console.WriteLine(item.ToString()); }

Console.WriteLine("==============Group By==============");

var grouped = stu35.GroupBy(student => student.Age);

foreach (var group in grouped)
{
    //Each group now have key - 20 21 22 30
    Console.WriteLine(group.Key + " => Age Bracket Count: " + group.Count());

    var maleStudents = group.Where(student => student.Gender == 'M');
    Console.WriteLine("Male Count: " + maleStudents.Count());
    foreach (var item in maleStudents)
    {
        Console.WriteLine(item.Fname + " " + item.Lname);
    }

    var femaleStudents = group.Where(student => student.Gender == 'F');
    Console.WriteLine("Female Count: " + femaleStudents.Count());
    foreach (var item in femaleStudents)
    {
        Console.WriteLine(item.Fname + " " + item.Lname);
    }
}

Console.WriteLine("===============Select===============");
Console.WriteLine("Select name start with 'S' and age ");
var q7 = stu35.Where(s => s.Fname.StartsWith('S')).Select(s => new { s.Fname, s.Age }).OrderByDescending(student => student.Age);
foreach (var item in q7)
{
    Console.WriteLine(item.ToString());
}

public class StudentEqualityComparer : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        return x.Fname == y.Fname && x.Lname == y.Lname;
    }

    public int GetHashCode([DisallowNull] Student obj)
    {
        return obj.Age.GetHashCode();
    }
}

public class Student 
{
    public string Fname { get; set; }
    public string Lname { get; set; }
    public int Age { get; set; }
    public char Gender { get; set; }

    public string ToString() {
        return this.Fname + " " + this.Age + " " + this.Gender; 
    }
}

