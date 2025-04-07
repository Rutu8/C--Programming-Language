
int fact,i,sum=1;
Console.WriteLine("Enter Number: ");
fact = int.Parse(Console.ReadLine()!);
//int fact = 1;
for (i=1;i<=fact;i++)
{
    sum = sum*i;
}  
Console.WriteLine("Factorial Number is: "+sum);
