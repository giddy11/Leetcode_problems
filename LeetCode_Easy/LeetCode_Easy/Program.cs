// See https://aka.ms/new-console-template for more information

int ClimbStairs(int n)
{
    if (n <= 2)
    {
        return n;
    }

    int prev1 = 1;
    int prev2 = 2;
    int current = 0;

    for (int i = 3; i <= n; i++)
    {
        current = prev1 + prev2;
        prev1 = prev2;
        prev2 = current;
    }
    return current;
    //1 2 3 4 5
    //1 2 3 5 8
}

Console.WriteLine(ClimbStairs(5));
