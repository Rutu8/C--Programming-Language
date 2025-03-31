//We can declare a as we want variables with data types
int num1, num2,  sum;
int sub;
int mult;
int div;

Console.WriteLine("Enter a first Number");
//it can accepts the warning if we want to give it not return null then you can give but if not wan't then keep it is
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a second Number");
num2 = int.Parse(Console.ReadLine());

sum = num1 + num2;
Console.WriteLine("Addition is: " + sum);

sub = num1 - num2;
Console.WriteLine("Subtraction is: " + sub);

mult = num1 * num2;
Console.WriteLine("Multiplication is: " + mult);

div = num1 / num2;
Console.WriteLine("Division is: " + div);

