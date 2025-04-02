int num, rem;
Console.WriteLine("*******************Digit Separation Program*********************");
Console.WriteLine("Enter a Number: ");
num = int.Parse(Console.ReadLine()!);
while(num>0)
{
    rem = num % 10;//It can be separate unit
    Console.WriteLine(rem);
    num = num / 10;//it can be separate tens
    //Console.WriteLine(num);

}
