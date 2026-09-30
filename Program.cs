namespace BasicTasks;

public static class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=== Basic. Ketma-ketlik: 2-amaliy vazifa ===");
            Console.WriteLine("1. Kalkulyator");
            Console.WriteLine("2. 1 dan N gacha sonlar yig'indisi");
            Console.WriteLine("0. Chiqish");
            Console.Write("Tanlang: ");

            string? choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1": Calculator.Run(); break;
                case "2": NumberSum.Run(); break;
                case "0": return;
                default: Console.WriteLine("Noto'g'ri tanlov."); break;
            }
        }
    }
}
