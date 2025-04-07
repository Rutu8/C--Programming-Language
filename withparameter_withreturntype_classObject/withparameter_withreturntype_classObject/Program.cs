using withparameter_withreturntype_classObject;

int n1, n2, result;
Console.WriteLine("Enter a first number: ");
    n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a Second number: ");
n2 = int.Parse(Console.ReadLine());
Division division = new Division();

result = division.getData(n1 , n2);
Console.WriteLine("division is: " + result);

//Console.ReadLine();