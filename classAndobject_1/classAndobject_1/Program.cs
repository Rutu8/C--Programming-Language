using classAndobject_1;

//using parameter function without return type
//Addition addition = new Addition();
//int num1, num2;
//Console.WriteLine("Enter a first Number: ");
//num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter a second Number: ");
//num2 = int.Parse(Console.ReadLine());
//addition.getdata(2, 3);
//addition.calculate();
//addition.display();

//using return type but no parameter
int result;
multiplication mult = new multiplication();
mult.get();
result = mult.calculate();
Console.WriteLine("Multiplication is: "+result);