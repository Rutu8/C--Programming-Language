int num, count=0;
Console.WriteLine("Enter a Number: ");
num = int.Parse(Console.ReadLine()!);

for(int i= 2; i<num; i++)
{
    if(num%i==0)
    {
        count++;
        break;

    }
}
if(count==0)
{
    Console.WriteLine("number is prime");
}
else
{
    Console.WriteLine("number is Not prime");
}