// RECURSION. Factorial

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        System.Console.WriteLine($"Stop recursion: {n}");
        return 1;
    }
    System.Console.WriteLine(n);
    return n * Fact(n - 1); // return !n * (n-1)!
}

System.Console.Write(Fact(5));

