string evenodd(int num)
{
    if(num%2==0)
    {
        return "Number is Even";
    }
    return "Number is Odd";
}
int num;
string result;
Console.WriteLine("Enter number: ");
num= int.Parse(Console.ReadLine()!);
result = evenodd(num);
Console.WriteLine(result);