int num;
Console.WriteLine("Enter a number: ");
num = int.Parse(Console.ReadLine()!);
if(num%2==0)
{
    Console.WriteLine("Number is Even");
}
else
{
    Console.WriteLine("Number is Odd");
}