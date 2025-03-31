int feet, inch;

Console.WriteLine("**********Convert Feet to Inch************");
Console.Write("Enter a Feet: ");
feet = int.Parse(Console.ReadLine()!);
inch = feet * 12;
Console.WriteLine("Inch is: " + inch);

Console.WriteLine("**************Convert Inch to Feet******************");
Console.Write("Enter a Inch: ");
inch = int.Parse(Console.ReadLine()!);
feet = inch / 12;
Console.WriteLine("Feet is: " + feet);

