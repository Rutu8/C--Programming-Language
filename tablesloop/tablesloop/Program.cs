int num;
Console.WriteLine("Enter Number: ");
num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Table of: " + num);
for(int i = 1; i<11;i++)
{
    Console.WriteLine(num*i);
}