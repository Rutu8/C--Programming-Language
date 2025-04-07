void change(ref int num)
{
    num = 10;
}
int num = 20;
Console.WriteLine(num);
change(ref num);
Console.WriteLine(num);