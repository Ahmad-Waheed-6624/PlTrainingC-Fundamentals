// // Contact Management with File Handling


using System.Text.Json;
using System.Text.Json.Serialization;
using MyNewApp.Models;

// System.Console.WriteLine("-------- Welcome to Phone Book app --------");
// System.Console.WriteLine("Press 1 to Add a New Contact");
// System.Console.WriteLine("Press 2 to Update a Contact");
// System.Console.WriteLine("Press 3 to Delete a Contact");
// System.Console.WriteLine("Press 4 to Display all Contact");
// System.Console.WriteLine("Press 5 to Search a Contact");
// System.Console.WriteLine("Press 0 to Exit");


// string? menuOptionString = Console.ReadLine();
// while (String.IsNullOrWhiteSpace(menuOptionString) || Convert.ToInt16(menuOptionString) > 5)
// {
//     System.Console.WriteLine("Invalid Or Null Input Please Try Again and Enter Number Between 0-5");
//     menuOptionString = Console.ReadLine();

// }



// int menuOption = Convert.ToInt16(menuOptionString);

// switch (menuOption)
// {
//     case 1:
//         System.Console.WriteLine("add");
//         break;
//     case 2:
//         System.Console.WriteLine("update");
//         break;
//     case 3:
//         System.Console.WriteLine("delete");
//         break;
//     case 4:
//         AllContact()
//         break;
//     case 5:
//         System.Console.WriteLine("search");
//         break;
//     case 0:
//         System.Console.WriteLine("exit");
//         break;
//     default:
//         System.Console.WriteLine("exit");
//         break;
// }
string path = @"D:\temp\phoneBook.json";
List<Contact> newContact =
[
    new Contact{  ID = Guid.NewGuid(), Name = "Ali",PhoneNo = "03225697828"},
    new Contact{  ID = Guid.NewGuid(), Name = "Ali",PhoneNo = "03225697828"},
    new Contact{  ID = Guid.NewGuid(), Name = "Ali",PhoneNo = "03225697828"},
];
string jsonString = JsonSerializer.Serialize<List<Contact>>(newContact);
File.WriteAllText(path, jsonString);

string AddContact()
{
    string? name;
    string? phone;
    System.Console.WriteLine("Enter Name");
    name = Console.ReadLine();
    while (String.IsNullOrWhiteSpace(name))
    {
        System.Console.WriteLine("Name Cannot be null");
        name = Console.ReadLine();
    }
    System.Console.WriteLine("Enter Phone No");
    phone = Console.ReadLine();
    while (String.IsNullOrWhiteSpace(phone))
    {
        System.Console.WriteLine("Phone no Cannot be null");
        phone = Console.ReadLine();
    }
    Contact newContact = new()
    {

    };

    return "Contact Added Successfully";
}



List<Contact> AllContact()
{
    string json = File.ReadAllText(path);
    List<Contact>? data = JsonSerializer.Deserialize<List<Contact>>(json);
    return data!;

}