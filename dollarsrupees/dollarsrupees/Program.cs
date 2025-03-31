double rs, usd;
double conversion_usd = 85.56;//Exchange rate converting dollars into rupees
double conversion_rs = 0.012;//Exchange rate converting rupees into dollars


Console.WriteLine("**********Convert Dollars into Rupees*************");
Console.Write("Enter Dollars: ");
usd = double.Parse(Console.ReadLine()!);
rs = (usd * conversion_usd);
Console.WriteLine("Rupees : " + rs);

Console.WriteLine("***************Convert Rupees into Dollars*******************");
Console.Write("Enter Rupees: ");
rs = double.Parse(Console.ReadLine()!);
usd = rs* conversion_rs;
Console.WriteLine("Dollars: " + usd);