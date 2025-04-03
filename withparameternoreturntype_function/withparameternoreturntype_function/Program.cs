//with parameter without return type
void sum(int num1, int num2)//void because it is not return type
{
    int result;
    result = num1 + num2;
    Console.WriteLine("Addition is: "+result);
}
int num1, num2;
Console.WriteLine("Enter a First Number: ");
num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a Second Number: ");
num2 = int.Parse(Console.ReadLine()!);
sum(num1, num2);
