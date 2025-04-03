int facto(int n)
{
    int fact;
    if(n==0)
    {
        fact = 1;
    }
    else
    {
        fact = (n*facto(n-1));
    }
    return fact;
}
int num, fact;
Console.WriteLine("Enter a Number: ");
num = int.Parse(Console.ReadLine()!);
fact=facto(num);
Console.WriteLine("Factorial is: " + fact);