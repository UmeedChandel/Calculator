﻿// See https://aka.ms/new-console-template for more information
using structLiberary;
using Calculator;

//LOOPS

//for

Console.Write("Enter Value :");
int value = Convert.ToInt32(Console.ReadLine());

for (int x = 0; x <= value; x++)
{
    Console.WriteLine("for loop running {0}", x);
    if (x == value)
    {
        Console.WriteLine("Last condition of for loop reached. ");
    }
}

Console.WriteLine(" ");

//while loop

int i = 0;

while (i < value)
{
    Console.WriteLine("i is {0} for while loop", i);

    i++;
}

Console.WriteLine(" ");

//do while loop

int j = 0;

do
{
    Console.WriteLine("inside do loop {0} time", j);
    j++;

} while (j <= value);

//CONDITION

// if and else and nested

Console.WriteLine("Consition Checked: ");
int a = 4, b = value;

if (a == b)
{
    Console.WriteLine("Both equal {0}! ",value);
}
else if (a > b)
{
    Console.WriteLine("Less than 4! ");
}
else if (a < b)
{
    Console.WriteLine("Greater than 4! ");
}

Console.WriteLine(" ");

//Value type 
Console.WriteLine(" Value Type! ");
int ram = 10;
int sham = ram;
Console.WriteLine(" Ram has {0}", ram);
Console.WriteLine(" Sham also has {0}", sham);
sham = 20;
Console.WriteLine(" ");
Console.WriteLine(" Now Ram has {0}", ram);
Console.WriteLine(" Sham has {0}", sham);

Console.WriteLine(" ");

//Refrence type
Console.WriteLine(" Reference Type! ");
ClassOperations Riya = new ClassOperations(10);
Console.WriteLine(" Riya has {0}", Riya.amount);
ClassOperations Diya = Riya;
Console.WriteLine(" Diya also has {0}", Diya.amount);
Console.WriteLine(" ");
Diya.amount = 20;
Console.WriteLine(" Now Riya has {0}", Riya.amount);
Console.WriteLine(" And Diya has {0}", Diya.amount);

Console.WriteLine(" ");
//c# data types

/*primitive + struct + enum - string
  value types
  stored in stack memory */

byte i1 = 3;        sbyte i5 = 0;
short i2=8;         ushort i6 = 98;
int i3 = 5;         uint i7 = 988;
long i4 = 2000;     ulong i8 = 98812;

float a1 = 98.0f;
double b1 = 1.09;
decimal c1 = 87467.9m;

bool t1 = false;
char t2 = 'o';
string t3 = "Data";


/*complex + string -struct - enum
  reference types
  stored heap memory */

Complex1 structObject = new Complex1();
Console.WriteLine(structObject.Addition(a1, 98.8f));
Console.WriteLine(structObject.Subtract(b1, 23.32));
Console.WriteLine(structObject.Multiply(c1, 2334.2m));
public class Complex2 // yes inheritance
{

} 
enum Complex3 { }
public interface Complex4 { }

//public delegate int Comples5{ int exp1, int exp2};
//stack int i = 10;
//heap A a = new A();


