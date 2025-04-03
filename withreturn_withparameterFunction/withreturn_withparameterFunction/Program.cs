//With return type with parameter

int sum(int num1, int num2)
{
    int result;
    result = num1 + num2;
    return result;
}

int num1, num2, result;
Console.WriteLine("Enter a First Number: ");
num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a Second Number: ");
num2 = int.Parse(Console.ReadLine()!);

result = sum(num1, num2);
Console.WriteLine("Addition is: "+result);
