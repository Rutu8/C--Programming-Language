// Base class
public class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

// Derived class inheriting from Animal
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

// Derived class inheriting from Dog (multilevel inheritance)
public class Poodle : Dog
{
    public void DoTrick()
    {
        Console.WriteLine($"{Name} is doing a trick.");
    }
}

// Main method to demonstrate
public class Example
{
    public static void Main(string[] args)
    {
        Poodle myPoodle = new Poodle { Name = "Buddy" };
        myPoodle.Eat(); // Inherited from Animal
        myPoodle.Bark(); // Inherited from Dog
        myPoodle.DoTrick(); // Defined in Poodle
    }
}