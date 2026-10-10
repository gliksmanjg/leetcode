static int Solution(int value)
{
    int sum = 0;

    for (int i = 0; i < value; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
            sum += i;

        if (value < 0) return 0;
    }

    return sum;
}

Console.WriteLine(Solution(10));