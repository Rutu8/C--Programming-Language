void sum()
{
    int num1, num2, result;
    Console.WriteLine("Enter a first Number: ");
    num1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter a second Number: ");
    num2 = int.Parse(Console.ReadLine()!);
    result = num1 + num2;
    Console.WriteLine("Addition Is: " + result);
}
sum();