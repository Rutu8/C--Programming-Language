int num1, num2;
Console.WriteLine("Enter a First Number");
num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a Second Number");
num2 = int.Parse(Console.ReadLine()!);
if(num1>num2)
{
    Console.WriteLine("First Number is Greater");
}
else
{
    Console.WriteLine("Second Number is Greater");
}