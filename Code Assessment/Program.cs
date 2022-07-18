/*create console application and solve the below problems. there are 15 problems are given. 
10 problems are based on students array. 5 problems are based integer array.
LINQ, Lambda Expressions, Implicitly typed local variables, Anonymous types, Extension methods are notable features in your implementation.
*/

var students = new List<Student> {
new Student{FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
new Student{FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
new Student{FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
new Student{FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
new Student{FirstName="Aishwarya",LastName="Verma",Age=19, Gender="F", TeamName="A" },

new Student{FirstName="Shreya",LastName="",Age=20, Gender="F", TeamName="B" },
new Student{FirstName="Nandhita",LastName="",Age=20, Gender="F", TeamName="B" },
new Student{FirstName="Shashwat",LastName="",Age=20, Gender="M", TeamName="B" },
new Student{FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
new Student{FirstName="Shriya",LastName="",Age=20, Gender="F", TeamName="B" },

new Student{FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
new Student{FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
new Student{FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
new Student{FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
new Student{FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },

new Student{FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
new Student{FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
new Student{FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
new Student{FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
new Student{FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
new Student{FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" }
};

Console.WriteLine("============ students array queries ============");

Console.WriteLine("Student List: ");
Student.Display(students);

Console.WriteLine("\n1. get all the students count for each team ");
var allStudentsGroups = students.GroupBy(group => group.TeamName); 
foreach (var group in allStudentsGroups)
    Console.WriteLine(" Team {0}'s Count is {1}. ",group.Key, group.Count());

Console.WriteLine("\n2. get all the male students list ");
var allMale = students.Where(student => student.Gender.ToUpper() == "M");
Student.Display(allMale);

Console.WriteLine("\n3. get all the female students list");
var allFemale = students.Where(student => student.Gender.ToUpper() == "F");
Student.Display(allFemale);

Console.WriteLine("\n4. get all the male students with age 20");
var allMaleAgeFilter = students.Where(student => student.Gender.ToUpper() == "M" && student.Age == 20);
Student.Display(allMaleAgeFilter);

Console.WriteLine("\n5. get all the female students with age 19");
var allFemaleAgeFilter = students.Where(student => student.Gender.ToUpper() == "F" && student.Age == 19);
Student.Display(allFemaleAgeFilter);

Console.WriteLine("\n6. get all the students starts with FirstName as 'A' or 'a'");
var studentsStartWithS = students.Where(student => student.FirstName.ToUpper().StartsWith('A'));
Student.Display(studentsStartWithS);

Console.WriteLine("\n7. get all the students whose lastname is ''(empty)");
var emptyLastName1 = students.Where(student => student.LastName == "");
Student.Display(emptyLastName1);

Console.WriteLine("\n8. get top 2 students in each team");

Console.WriteLine("\n Approach 1");
var topStudents1 = students.GroupBy(student => student.TeamName);
foreach (var group in topStudents1)
{
    Console.Write("\n Team " + group.Key + " top 2 students: ");
    var q = students.Where(student => student.TeamName == group.Key).Take(2);
    foreach (var i in q)
        Console.Write(" " + i.FirstName + " ");
}
Console.WriteLine("\n");

Console.WriteLine("\n Approach 2");
var topStudents2 = students.GroupBy(group => group.TeamName).SelectMany(student => student.Take(2));
foreach (var item in topStudents2)
    Console.Write("\n Team {0}'s top 2 student: {1} ", item.TeamName, item.FirstName);

Console.WriteLine("\n\n9. get the students from 8th position to 17th position");
var rangeOfStudents = students.Take(new Range(8, 17));
Student.Display(rangeOfStudents);

Console.WriteLine("\n10. get all the students FirstName with Age");

Console.WriteLine("\n Approach 1\n");
var firstNameAndAge1 = students;
foreach (var item in firstNameAndAge1)
    Console.WriteLine(" Frist Name: " + item.FirstName+ "\t Age: " +item.Age);

Console.WriteLine("\n Approach 2\n");
var firstNameAndAge2 = students.ConvertAll(student => student.FirstName+ " "+ student.Age);
foreach (var item in firstNameAndAge2)
    Console.WriteLine(" "+item);

Console.WriteLine("\n Approach 3\n");
var firstNameAndAge3 = students.Select(student => new { student.FirstName, student.Age }); 
foreach (var item in firstNameAndAge3)
    Console.WriteLine(" " + item);

var numbers = new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 8 };

Console.WriteLine("\n============ integer array queries ============");

Console.Write("Numers List: ");
foreach (var n in numbers)
    Console.Write(n + " ");

Console.WriteLine("\n1. find the unique element in this list");
var uniqueElement = numbers.GroupBy(group => group).Where(g => g.Count() == 1).Select(k => k.Key);
Console.WriteLine(" unique element: " + uniqueElement.FirstOrDefault());

Console.WriteLine("\n2. find the distinct elements");
var distinctElements = numbers.Distinct();
foreach (var num in distinctElements)
    Console.Write(" " + num + " ");

Console.WriteLine("\n\n Approach 1");
var frequency1 = numbers.GroupBy(group => group).OrderBy(g => g.Count());

Console.Write("\n3. find the maximum occurred element: " + frequency1.Last().Key);
Console.Write("\n\n4. find the minimum occurred element: " + frequency1.First().Key);

Console.WriteLine("\n\n Approach 2");

var frequency2 = numbers.GroupBy(group => group).Select(g => new { g.Key, Count = g.Count() });

var maxValue = frequency2.Where(g => g.Count == frequency2.Max(g => g.Count)).Select(g => g.Key).SingleOrDefault();
var minValue = frequency2.Where(g => g.Count == frequency2.Min(g => g.Count)).Select(g => g.Key).SingleOrDefault();

Console.Write("\n3. find the maximum occurred element: " + maxValue);
Console.Write("\n\n4. find the minimum occurred element: " + minValue);

Console.WriteLine("\n\n5. find the even and odd numbers");
Console.Write(" even: ");
var evenNumbers = numbers.Where(num => num % 2 == 0);
foreach (var num in evenNumbers)
    Console.Write(" " + num + " ");

Console.Write("\n odd: ");
var oddNumbers1 = numbers.Where(num => !(num % 2 == 0));
foreach (var num in oddNumbers1)
    Console.Write(" " + num + " ");

Console.WriteLine("\n\n Another Approach");
Console.Write("\n odd: ");
var oddNumbers2 = numbers.Except(evenNumbers);
foreach (var num in oddNumbers2)
    Console.Write(" " + num + " ");

Console.WriteLine("\n");

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string TeamName { get; set; }
    public string ToString()
    {
        return " Name: " + FirstName + " " + LastName + " Age: " + Age + " Gender: " + Gender + " Team: " + TeamName;
    }
    public static void Display(IEnumerable<Student> students)
    {
        foreach (var student in students)
            Console.WriteLine(student.ToString());
    }

}

/*
Summary

LINQ Methods

First() FirstOrDefault() Last() SingleOrDefault()
Take() Range() ToUpper() ConvertAll()
Count() Min() Max() Distinct() StartsWith()

Projection: Select() SelectMany() 
Filter: Where() 
Grouping: GroupBy() 
Sorting: OrderBy()

Lambda Expressions (=>)
Implicitly typed local variables (var)
Anonymous types (new { })
Extension methods( . )
*/
