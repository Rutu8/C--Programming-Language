int num;
Console.WriteLine("Enter Your Age: ");
num = int.Parse(Console.ReadLine()!);
//if(num>=18)
//{
//    Console.WriteLine("You are eligible for Voting");
//}
//else
//{
//    Console.WriteLine("You are not eligible for voting");
//}

//Ternary Operator
string result = num >= 18 ? "You are eligible for Voting" : "You are not eligible for Voting";
Console.WriteLine(result);