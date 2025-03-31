int num1, num2, result;
//Here you pass interger therefor it need to be type casting because console.ReadLine reads string
Console.WriteLine("Enter a first Number: ");
num1 = int.Parse(Console.ReadLine()!);//Here if you not write a not null then it gives a warning that it takes null value but you can ignore warnings and run program but if don't want warnings then you must be write not null

Console.WriteLine("Enter a Second Number");
num2 = int.Parse(Console.ReadLine()!);

result = num1 + num2;
Console.WriteLine("Addition is: " + result);

