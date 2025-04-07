using thiskeywordClassObject;

int num1;
Console.WriteLine("Enter a Number: ");
num1 = int.Parse(Console.ReadLine());

Eventodd evenodd = new Eventodd();
evenodd.getData(num1);
evenodd.calculation();