int num1, num2, num3;
Console.WriteLine("Enter a First number: ");
num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a Second number: ");
num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a Third number: ");
num3 = int.Parse(Console.ReadLine()!);

if(num1>num2 && num1>num3)
{
    Console.WriteLine("First Number is Greater");
}else if(num2 > num1 && num2 > num3)
{
    Console.WriteLine("Second Number is Greater");
}else if(num3 > num1 && num3>num2)
{
    Console.WriteLine("Third Number is Greater");
}
else
{
    Console.WriteLine("Numbers are Same");
}