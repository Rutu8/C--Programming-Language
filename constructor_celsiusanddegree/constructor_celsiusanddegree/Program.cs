using constructor_celsiusanddegree;

Console.WriteLine("**********To Convert Celsius to Fahrenheit**********");
int c, fahrenheit;
Console.WriteLine("Enter a Celsius: ");
c = int.Parse(Console.ReadLine()!);  

Temperature temperature = new Temperature(c);
temperature.calculate();
fahrenheit=temperature.gettemperature();
Console.WriteLine("Fahrenheit is: " + fahrenheit);