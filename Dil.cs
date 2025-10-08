using System;

class Program
{
    // Функція, для якої шукаємо корінь: f(x) = x^2 - 2
    static double Function(double x)
    {
        return x * x - 2;
    }

    // Метод ділення навпіл
    static double Bisection(double a, double b, double eps)
    {
        double c;

        if (Function(a) * Function(b) > 0)
        {
            throw new Exception("На цьому інтервалі немає кореня або їх парна кількість.");
        }

        while ((b - a) / 2 > eps)
        {
            c = (a + b) / 2;

            if (Function(c) == 0)
                return c;

            if (Function(a) * Function(c) < 0)
                b = c;
            else
                a = c;
        }

        return (a + b) / 2;
    }

    static void Main()
    {
        double a = 0;
        double b = 2;
        double eps = 0.0001;

        try
        {
            double root = Bisection(a, b, eps);
            Console.WriteLine($"X: {root}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }

        Console.ReadKey();
    }
}
