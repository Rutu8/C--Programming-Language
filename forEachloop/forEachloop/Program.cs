string[] days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
int ctrl = 0;//To create index

foreach(string day in days)//here datatype string is used because we declare days as string
{
    ctrl++;
    Console.WriteLine(ctrl+" -"+day);
}


int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
foreach(int number in numbers)
{
    Console.WriteLine(number);
}