Console.WriteLine("******************Fibonacci Series*********************");
//limit is which you upto series
int num1 = 0, num2 = 1, temp, i = 0, limit;
Console.WriteLine("Enter limit You want: ");
limit = int.Parse(Console.ReadLine()!);
while (i < limit)
{
    Console.WriteLine(" " + num1);
    temp = num1 + num2;
    num1 = num2;
    num2 = temp;
    i++;

}