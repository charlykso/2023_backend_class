// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// OopClass.Car volvo = new OopClass.Car();
// OopClass.Car toyota = new OopClass.Car();

// volvo.color = "green";
// volvo.maxSpeed = 80;
// toyota.color = "red";
// toyota.maxSpeed = 120;

// Console.WriteLine(volvo.color);
// Console.WriteLine(toyota.color);

OopClass.Car newCar = new OopClass.Car();
newCar.honk();

Console.WriteLine(newCar.brand +" "+ newCar.ModelName);

OopClass.NormalUser newUser = new OopClass.NormalUser();

newUser.firstname = "Emmanuel";
newUser.lastname = "Eze";
newUser.email = "emmanuel@gmail.com";
newUser.phoneNo = "+2347056453423";
newUser.year = 100;
newUser.created_at = DateTime.Now;
newUser.updated_at = DateTime.Now;

OopClass.Admin newAdmin = new OopClass.Admin();

newAdmin.firstname = "Ikenna";
newAdmin.lastname = "Remigius";
newAdmin.created_at = DateTime.Now;


OopClass.Dog newDog = new OopClass.Dog();
OopClass.Pig newPig = new OopClass.Pig();
// OopClass.Animal newAnimal = new OopClass.Animal();

newDog.makeNoise();
newPig.makeNoise();
// newAnimal.makeNoise();
newDog.name = "Wisky";
newDog.ear = 2;
Console.WriteLine(newDog.name);