int num, rem, sum =0, temp;
Console.WriteLine("**********Palindrome Numbers***********");
Console.WriteLine("Enter a number: ");
num = int.Parse(Console.ReadLine()!);
temp = num;
while(num>0)
{
    rem = num % 10;
    //Console.WriteLine("rem" + rem);  //just for understanding
    sum = (sum * 10) + rem;
    //Console.WriteLine("sum" + sum);   //just for understanding
    num = num / 10;
    //Console.WriteLine("num" + num);   //just for understanding
}
if (sum == temp)
{
    Console.WriteLine("Number is palindrome");
}
else
{
    Console.WriteLine("Number is Not Palindrome");
}
