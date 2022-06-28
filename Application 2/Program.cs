// See https://aka.ms/new-console-template for more information
using ClassLibrary;

ClassOne partialObject = new ClassOne();
int Answer1 = partialObject.Subtract(20, 10);//instance partial method, so called by object
int Answer2 = ClassOne.Add(10, 10);//static partial method, so called by class name

Console.WriteLine("Answer for instance method {0} and static method {1}",Answer1,Answer2);