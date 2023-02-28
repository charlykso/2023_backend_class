// See https://aka.ms/new-console-template for more information

InterfaceExample.Vehicle newVehicle = new InterfaceExample.Vehicle();

int newLevel = (int) InterfaceExample.level.High;

double amount = 750.5;
int newAmount = (int) amount;

newVehicle.name = "Toyota";
newVehicle.price = 200000;
newVehicle.model = "2023";

Console.WriteLine(newVehicle.name);
Console.WriteLine(newVehicle.model);
Console.WriteLine(newVehicle.price);

newVehicle.hunk();
newVehicle.move();
Console.WriteLine(newLevel);

Console.WriteLine(newAmount);