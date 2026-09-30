namespace BasicTasks;

/// <summary>3-topshiriq: kiritilgan son juft yoki toq ekanini aniqlash.</summary>
public static class ParityChecker
{
    public static void Run()
    {
        long number = InputHelper.ReadLong("Sonni kiriting: ");
        Console.WriteLine(Check(number));
    }

    public static string Check(long number) => number % 2 == 0 ? "Toq" : "Juft";
}
