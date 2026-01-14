// // // // Contact Management with File Handling


// // using MyNewApp.Models;
// // using MyNewApp.Utils;
// // using System.Text.Json;

using Microsoft.VisualBasic;

IProgram.Hello();






// // MessageUtils.ShowMenu();


// // string path = @"D:\temp\phoneBook.json";
// // List<Contact> AllContact()
// // {
// //     string json = File.ReadAllText(path);
// //     List<Contact>? data = JsonSerializer.Deserialize<List<Contact>>(json);
// //     return data!;

// // }

// // void AddContact()
// // {
// //     List<Contact> all = AllContact();
// //     string? name;
// //     string? phone;
// //     Console.WriteLine("Enter Name");
// //     name = Console.ReadLine();
// //     while (String.IsNullOrWhiteSpace(name))
// //     {
// //         Console.WriteLine("Name Cannot be null");
// //         name = Console.ReadLine();
// //     }
// //     Console.WriteLine("Enter Phone No");
// //     phone = Console.ReadLine();
// //     while (String.IsNullOrWhiteSpace(phone))
// //     {
// //         Console.WriteLine("Phone no Cannot be null");
// //         phone = Console.ReadLine();
// //     }
// //     Contact newContact = new()
// //     {
// //         ID = Guid.NewGuid(),
// //         Name = name,
// //         PhoneNo = phone

// //     };
// //     var contact = all.FirstOrDefault(contact => contact.PhoneNo == phone);
// //     if (contact != null)
// //     {
// //         Console.WriteLine("This Phone No is already exist");
// //         return;
// //     }
// //     all.Add(newContact);
// //     string jsonString = JsonSerializer.Serialize<List<Contact>>(all);
// //     File.WriteAllText(path, jsonString);
// //     Console.WriteLine("Contact Added Successfully");
// // }


// // List<int> arr = [21, 32, 34, 42, 23, 45, 65, 55];

// // IEnumerable<int> result =
// // from val in arr
// // where val > 40
// // select val;

// var myDict = new Dictionary<string, int>
// {
//  { "name",11},
//  { "age",12},
//  { "address",10},
// };

// var result = from dict in myDict
//              where dict.Key == "age"
//              select dict.Value;

// var result2 = myDict.Where(dic => dic.Value > 10).ToList();
// // myDict.Add("name", "ali");
// System.Console.WriteLine(result2[1]);
// // foreach (var item in result2)
// // {
// //     System.Console.WriteLine(item);
// // }

// string prenthesis = "{<[]>>}";

// bool isValidPrenthesis(string val)
// {
//     var mystack = new Stack<char>();
//     bool isValid = false;
//     for (int i = 0; i < val.Length; i++)
//     {
//         if (mystack.Count > 0 && mystack.Peek() == val[i])
//         {
//             mystack.Pop();
//             continue;
//         }
//         mystack.Push(val[i]);

//     }
//     if (mystack.Count == 0)
//     {
//         isValid = true;
//     }
//     return isValid;
// }

// var mystack = new Stack<int>();

// mystack.Push(89);
// mystack.Push(78);
// mystack.Push(90);

// System.Console.WriteLine(mystack.Peek());

// bool isValid = isValidPrenthesis(prenthesis);
// string message = isValid ? "this is a valid sequance" : "this is invalid sequance";
// System.Console.WriteLine(message);

// namespace MyNewApp;

void typeChecker<T>(T value)
{
    System.Console.WriteLine(value);
}

typeChecker("hello");
BetterList<int> better = new();
better.AddtoList(6);
better.AddtoList(7);
public class BetterList<T>
{
    public List<T> values = new();
    public void AddtoList(T val)
    {
        values.Add(val);
        System.Console.WriteLine($"{val} is added to the list");
    }
}



public abstract class Person(string name, string lastname, DateOnly birthday)
{
    public string Name { get; } = name;
    public string LastName { get; } = lastname;
    public DateOnly BirthDay { get; } = birthday;
    public abstract void ArrangeMeeting();
    public static void Hello()
    {
        System.Console.WriteLine("this is hello");
    }
};

// this is using the primary constructor
public class Manager(string name, string lastname, DateOnly birthday) : Person(name, lastname, birthday)
{
    public override void ArrangeMeeting()
    {
        System.Console.WriteLine("i arrange a meeting");
    }

}

// this is an other way of use constructor of the base class
public class Intern : Person
{
    public Intern(string name, string lastname, DateOnly birthday) : base(name, lastname, birthday)
    {

    }
    public override void ArrangeMeeting()
    {
        System.Console.WriteLine("i can also arrange a meeting");
    }
}


public interface IProgram
{
    public static void Hello()
    {
        System.Console.WriteLine("hello");
    }
    public void PrintName()
    {
        System.Console.WriteLine("Hello");
    }
}
public class MyProgram : IProgram
{

}





