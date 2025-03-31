// different Datatypes in C# Programming Language

//1.string 
string str;
Console.WriteLine("Enter a String: ");
//always remember a (!) symbol
str = Console.ReadLine()!;
Console.WriteLine("Given String is: " + str);

//2. char 
char ch;
Console.WriteLine("Enter a Character You want: ");
ch = Console.ReadLine()![0];//compulsory give index number which you character want, if you want only one then also write index number
Console.WriteLine("Character is : "+ch);

// 3. Int
int num;
Console.WriteLine("Enter Number: ");
num = int.Parse(Console.ReadLine()!);//compulsory convert do type casting
//num = Convert.ToInt32(Console.ReadLine());//This is another type of type casting you can use any type one of them
Console.WriteLine("Number is: " + num);

//4.double 
double dnum;
Console.WriteLine("Enter Double number: ");
dnum = double.Parse(Console.ReadLine());
//dnum = Convert.ToDouble(Console.ReadLine());//This is another type of casting you can use any type one of them 
Console.WriteLine("Double number is: " + dnum);

//5. bool
bool boolValue;
Console.WriteLine("Enter a true of false");
boolValue = Console.ReadLine() == "true";
Console.WriteLine(boolValue);   