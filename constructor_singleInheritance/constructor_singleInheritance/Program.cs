using constructor_singleInheritance;

Console.WriteLine("**************Single Inheritance and Parameterized Constructor*************");

string name,  sound,  eat,  run;

Console.WriteLine("Can Animals Eat?");
eat = Console.ReadLine();
Console.WriteLine("Can Animals Run?");
run = Console.ReadLine();
Console.WriteLine("Name of the Animal: ");
name = Console.ReadLine();
Console.WriteLine("Sound of Animal: " + name);
sound = Console.ReadLine();

Dog dog = new Dog(name,sound,eat,run);
dog.displayanimal();
dog.getdisplayDog();
