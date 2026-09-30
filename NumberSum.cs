namespace BasicTasks;

/// <summary>2-topshiriq: 1 dan N gacha bo'lgan sonlar yig'indisi.</summary>
public static class NumberSum
{
    public static void Run()
    {
        long n = InputHelper.ReadPositiveLong("N musbat butun sonni kiriting: ");
        Console.WriteLine($"1 dan {n} gacha sonlar yig'indisi: {SumTo(n)}");
    }

    public static long SumTo(long n)
    {
        long sum = 0;
        for (long i = 1; i <= n; i++)
            sum += i;
        return sum;
    }
}
