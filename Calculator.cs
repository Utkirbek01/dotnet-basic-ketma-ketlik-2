using System.Globalization;

namespace BasicTasks;

/// <summary>1-topshiriq: ikkita son va operatsiya (+, -, *, /) bo'yicha natija.</summary>
public static class Calculator
{
    public static void Run()
    {
        double a = InputHelper.ReadDouble("Birinchi sonni kiriting: ");
        char op = ReadOperator();
        double b = InputHelper.ReadDouble("Ikkinchi sonni kiriting: ");

        if (op == '/' && b == 0)
        {
            Console.WriteLine("Xato: nolga bo'lish mumkin emas.");
            return;
        }

        double result = Calculate(a, op, b);
        Console.WriteLine($"Natija: {result.ToString(CultureInfo.InvariantCulture)}");
    }

    public static double Calculate(double a, char op, double b) => op switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        '/' => b == 0 ? throw new DivideByZeroException() : a / b,
        _ => throw new ArgumentException($"Noma'lum operatsiya: {op}")
    };

    private static char ReadOperator()
    {
        while (true)
        {
            Console.Write("Operatsiyani kiriting (+, -, *, /): ");
            string? text = Console.ReadLine()?.Trim();
            if (text is { Length: 1 } && "+-*/".Contains(text[0]))
                return text[0];
            Console.WriteLine("Faqat +, -, * yoki / kiriting.");
        }
    }
}
