int bit, Byte;

Console.WriteLine("**********bit to byte conversion***************");
Console.Write("Enter a bit: ");
bit = int.Parse(Console.ReadLine()!);
Byte = bit / 8;
Console.WriteLine("byte is : " + Byte);

Console.WriteLine("**********byte to bit Conversion**************");
Console.Write("Enter a byte is: ");
Byte = int.Parse(Console.ReadLine()!);
bit = Byte * 8;
Console.WriteLine("Bit is :" + bit);