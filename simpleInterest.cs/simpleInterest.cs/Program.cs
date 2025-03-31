int p, r, t;
int simple_Interest;
Console.WriteLine("Enter a Principle: ");
p = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a Rate: ");
r= int.Parse(Console.ReadLine()!) ;
Console.WriteLine("Enter a Time: ");
t = int.Parse(Console.ReadLine()!);
simple_Interest = p * r * t / 100;
Console.WriteLine("Simple Interest is: " + simple_Interest);

