// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
ClassExample.User newUser = new ClassExample.User();

newUser.firstname = "John";
newUser.password = "Onwe";
newUser.phoneNo = "+2347065432312";
newUser.created_at = DateTime.Now;

Console.WriteLine(newUser.created_at);