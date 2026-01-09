// See https://aka.ms/new-console-template for more information
using MyNewApp.Models;
// create a simple object of a class with default constructor
Person p1 = new()
{
    ID = 1,
    Address = "This is my address",
    Age = 18,
    Name = "Ahmad",
    Mail = "This is my mail"
};
// getting the static member function of static class
int age = NewPerson.GetAge();

// change this to handle null exception error
System.Console.WriteLine("Enter Your Name");
string? name = Console.ReadLine();
System.Console.WriteLine("Enter Your Age");
string? ageInput = Console.ReadLine();
System.Console.WriteLine("Enter Your Address");
string? address = Console.ReadLine();
int age2 = int.Parse(ageInput);
// int[] arr1 = [1, 2, 3, 4, 5, 6];

// for (int i = 0; i <= arr1.Length - 1; i++)
// {
//     System.Console.WriteLine($"this is my array value ${arr1[i]}");
// }

System.Console.WriteLine($"My name is ${name} and i am {age2} year old and my address is {address}");
