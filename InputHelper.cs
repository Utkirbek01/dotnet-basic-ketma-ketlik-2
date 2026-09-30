using System.Globalization;

namespace BasicTasks;

public static class InputHelper
{
    public static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? text = Console.ReadLine()?.Trim().Replace(',', '.');
            if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                return value;
            Console.WriteLine("Iltimos, to'g'ri son kiriting.");
        }
    }

    public static long ReadPositiveLong(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (long.TryParse(Console.ReadLine()?.Trim(), out long value) && value > 0)
                return value;
            Console.WriteLine("Iltimos, musbat butun son kiriting.");
        }
    }

    public static long ReadLong(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (long.TryParse(Console.ReadLine()?.Trim(), out long value))
                return value;
            Console.WriteLine("Iltimos, butun son kiriting.");
        }
    }
}
