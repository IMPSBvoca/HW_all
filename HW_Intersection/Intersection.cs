using System;
using System.Reflection.Metadata.Ecma335;


namespace HW_1_2
{
    class Solution
    {

        static List<int> Intersection(int start1, int end1, int start2, int end2)
        {
            int intersectionStart = Math.Max(start1, start2);
            int intersectionEnd = Math.Min(end1, end2);

            if (intersectionStart > intersectionEnd)
            {
                return new List<int>();
            }

            var intersectionPoints = new List<int>();

            for (int i = intersectionStart; i <= intersectionEnd; i++)
            {
                intersectionPoints.Add(i);
            }

            return intersectionPoints;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координатные точки 2х отрезков:");
            Console.Write("Начало первого отрезка: ");
            int start1 = int.Parse(Console.ReadLine());
            Console.Write("Конец первого отрезка: ");
            int end1 = int.Parse(Console.ReadLine());
            Console.Write("Начало второго отрезка: ");
            int start2 = int.Parse(Console.ReadLine());
            Console.Write("Конец второго отрезка: ");
            int end2 = int.Parse(Console.ReadLine());

            var intersection = Intersection(start1, end1, start2, end2);

            if (intersection.Count == 0)
            {
                Console.WriteLine("Пустое множество!");
            }
            else if (intersection.Count == 1)
            {
                Console.WriteLine($"Точка пересечения: {intersection[0]}");
            }
            else
            {
                Console.WriteLine($"Диапазон пересечения: {string.Join(", ", intersection)}");
            }
        }

    }
}