Console.WriteLine("**************Net Salary****************");
int Total_salary, Gross_salary, income_tax, employee_pf;
int professional_tax, deduction;
int Bs, HRA, other_allowances, bonus;

//To get Gross Salary
Console.WriteLine("Enter Basic Salary: ");
Bs = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Housing Rate Allowance: ");
HRA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Other Allowances: ");
other_allowances = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Bonus: ");
bonus = int.Parse(Console.ReadLine()!);
Gross_salary = Bs + HRA + other_allowances + bonus;
Console.WriteLine("Gross Salary is: " + Gross_salary);

//To get deduction
Console.WriteLine("Enter a Income Tax to pay: ");
income_tax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a Employee pf: ");
employee_pf = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a Professional Tax: ");
professional_tax = int.Parse(Console.ReadLine()!);
deduction = income_tax + employee_pf + professional_tax;
Console.WriteLine("Deduction is: " + deduction);

//Calculate Total salary or net Salary
Total_salary = Gross_salary + deduction;
Console.WriteLine("Total Salary is: " + Total_salary);



