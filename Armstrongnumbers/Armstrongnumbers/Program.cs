int num, rem, sum = 0, temp;
Console.WriteLine("*******ArmStrong Numbers********");
Console.WriteLine("Enter a Number: ");
num = int.Parse(Console.ReadLine()!);
temp = num;
while(num>0)
{
    
    rem = num % 10;
   // Console.WriteLine("remainder" +rem); //only for understanding
    sum += rem * rem *rem;
    // Console.WriteLine("sum"+sum); //only for understanding
    num = num / 10;
    // Console.WriteLine("num"+num); //only for understanding
}
if (sum == temp)
{
    Console.WriteLine("Number is Armstrong");

}
else
{
    Console.WriteLine("Number is not Armstrong");
}