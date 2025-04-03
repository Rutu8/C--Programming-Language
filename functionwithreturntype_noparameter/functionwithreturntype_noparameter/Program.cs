//with return type without parameter
int sum()
{
    int num1, num2, result;
    Console.WriteLine("Enter a Number one: ");
    num1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter a Number second: ");
    num2 = int.Parse(Console.ReadLine()!);
    result = num1 + num2;
    return result;

}

int result;
result = sum();
Console.WriteLine("Addition is: " + result);
