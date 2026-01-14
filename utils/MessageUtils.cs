// namespace MyNewApp.Utils;

// static class MessageUtils
// {
//     public static void ShowMenu()
//     {
//         Console.WriteLine("-------- Welcome to Phone Book app --------");
//         Console.WriteLine("Press 1 to Add a New Contact");
//         Console.WriteLine("Press 2 to Update a Contact");
//         Console.WriteLine("Press 3 to Delete a Contact");
//         Console.WriteLine("Press 4 to Display all Contact");
//         Console.WriteLine("Press 5 to Search a Contact");
//         Console.WriteLine("Press 0 to Exit");


//         string? menuOptionString = Console.ReadLine();
//         while (String.IsNullOrWhiteSpace(menuOptionString) || Convert.ToInt16(menuOptionString) > 5)
//         {
//             Console.WriteLine("Invalid Or Null Input Please Try Again and Enter Number Between 0-5");
//             menuOptionString = Console.ReadLine();

//         }



//         int menuOption = Convert.ToInt16(menuOptionString);

//         switch (menuOption)
//         {
//             case 1:
//                 AddContact();
//                 break;
//             case 2:
//                 Console.WriteLine("update");
//                 break;
//             case 3:
//                 Console.WriteLine("delete");
//                 break;
//             case 4:
//                 AllContact();
//                 Console.Clear();
//                 break;
//             case 5:
//                 Console.WriteLine("search");
//                 break;
//             case 0:
//                 Console.WriteLine("exit");
//                 break;
//             default:
//                 Console.WriteLine("exit");
//                 break;
//         }
//     }
// }
