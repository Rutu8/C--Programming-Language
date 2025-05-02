
using EncapsulationGetSet;

Person person  = new Person();
person.Name = "ABC";
Console.WriteLine(person.Name);
person.adharno = "12345678909";
Console.WriteLine(person.adharno);
person.display();
Console.WriteLine(person.Name);

person.display("xyz");
Console.WriteLine(person.Name);
Console.WriteLine(person.Name);