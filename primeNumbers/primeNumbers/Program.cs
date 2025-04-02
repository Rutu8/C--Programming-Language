int num, count=0;
Console.WriteLine("Enter a Number: ");
num = int.Parse(Console.ReadLine()!);

for(int i= 2; i<100; i++)
{
    if(num%i ==0)
    {
        count++;

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