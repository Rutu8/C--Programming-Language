using multileveinheritance_withparametirezedConstructor;
//using parameterized constructor
string name, carModel, color, fueltype, type;
int price;

Console.WriteLine("Enter Name of the Vehicle: ");
name = Console.ReadLine()!;
Console.WriteLine("Enter type of the Vehicle: ");
type = Console.ReadLine()!;
Console.WriteLine("Enter a Car Model: ");
carModel = Console.ReadLine()!;
Console.WriteLine("Enter a Color of the car: ");
color = Console.ReadLine()!;
Console.WriteLine("Enter a Type of Fuel: ");
fueltype = Console.ReadLine()!;
Console.WriteLine("Enter a Price of the Electric car:");
price = int.Parse(Console.ReadLine()!);

Chargingcar car = new Chargingcar(price,fueltype,carModel,color,name,type);
car.displayvehicle();
car.displaycar();
car.displaycharging();