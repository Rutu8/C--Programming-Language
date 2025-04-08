int i, j, Count;
void get()
{
    for(int i = 2; i <= 100; i++)
    {
        for(int j=2; j <= 100; j++)
        {
            if(i%j == 0)
            {
                Count++;
                break;
            }
        }
    }
    if (i == j)
    {
        Console.WriteLine("Prime Numbers: " + i);
    }

}

get();