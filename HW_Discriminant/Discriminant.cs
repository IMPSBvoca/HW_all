using System;

class Solution
{
    static void Main()
    {
        Console.WriteLine("Введите коэффициент a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коэффициент b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коэффициент c:");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Уравнение имеет два корня: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Уравнение имеет один корень: x = {x}");
        }
        else
        {
            Console.WriteLine("Корней нет.");
        }
    }
}