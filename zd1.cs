using System;

class Program
{
    static void Pudge(float start, float end, float step)
    {
        for (float x = start; x <= end; x += step)
        {
            float result;
            if (x >= -4 && x <= -2)
            {
                result = x + 3;
                Console.WriteLine($"{x}\t{result}");
            }
            if (x > -2 && x <= 4)
            {
                result = -0.5f * x;
                if (result == 0) result = Math.Abs(result);
                Console.WriteLine($"{x}\t{result}");
            }
            if (x > 4 && x <= 6)
            {
                result = -2;
                Console.WriteLine($"{x}\t{result}");
            }
            if (x >= 6 && x <= 10)
            {
                result = Convert.ToSingle(Math.Round((1 * (Math.Sqrt(4 - (Math.Pow(x - 8, 2)))) - 2) * 100) / 100);
                Console.WriteLine($"{x}\t{result}");
            }
        }
    }

    static void Main()
    {
        float xstart, xend, step;
        Console.WriteLine("Введите начальный x: ");
        xstart = float.Parse(Console.ReadLine());
        Console.WriteLine("Введите конечный x: ");
        xend = float.Parse(Console.ReadLine());
        Console.WriteLine("Введите шаг: ");
        step = float.Parse(Console.ReadLine());
        Console.WriteLine("X\tY");
        Pudge(xstart, xend, step);
    }
}
