using parameterized_constructor;

int rollno;
string name, subject;
float marks;
Console.WriteLine("Enter Your Roll No: ");
rollno = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Your Name: ");
name = Console.ReadLine()!;
Console.WriteLine("Enter Your Subject: ");
subject = Console.ReadLine()!;
Console.WriteLine("Enter Your Marks: ");
marks = float.Parse(Console.ReadLine()!);

Students student = new Students(rollno, name, subject, marks);
student.display();

