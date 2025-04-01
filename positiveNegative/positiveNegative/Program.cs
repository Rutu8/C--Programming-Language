int num;
Console.WriteLine("Enter a Number: ");
num = int.Parse(Console.ReadLine()!);

if(num>0)
{
    Console.WriteLine("Given Number is Positive");
}else if(num<0)
{
    Console.WriteLine("Given Number is Negative");
}
else
{
    Console.WriteLine("Number is Neutral");
}