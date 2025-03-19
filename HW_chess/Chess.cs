using System;


namespace HW_1_3
{
    class Solution
    {
        static void SameColor(int x1, int y1, int x2, int y2)
        {
            if ((x1 + y1) % 2 == (x2 + y2) % 2)
            {
                Console.WriteLine("Цвет одинаковый!");
            }
            else
            {
                Console.WriteLine("Цвет разный!");
            }
        }

        static bool BishopMove(int x1, int y1, int x2, int y2)
        {
            return (x1 + y1) % 2 == (x2 + y2) % 2 && Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }

        static bool QueenMove(int x1, int y1, int x2, int y2)
        {
            return x1 == x2 || y1 == y2 || Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }

        static bool KnightMove(int x1, int y1, int x2, int y2)
        {
            return (Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1) || (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2);
        }

        static void Main(string[] args)
        {
            int xCoord_1, yCoord_1, xCoord_2, yCoord_2;
            string figureChoice;

            Console.WriteLine("Введите координаты первой клетки: ");
            xCoord_1 = int.Parse(Console.ReadLine());
            yCoord_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координатны второй клетки: ");
            xCoord_2 = int.Parse(Console.ReadLine());
            yCoord_2 = int.Parse(Console.ReadLine());

            SameColor(xCoord_1, yCoord_1, xCoord_2, yCoord_2);

            Console.WriteLine();
            Console.WriteLine("Выберите фигуру для определения возможности хода: конь, ферзь или слон?");
            figureChoice = Console.ReadLine();

            switch (figureChoice)
            {
                case "конь":
                    if (KnightMove(xCoord_1, yCoord_1, xCoord_2, yCoord_2))
                    {
                        Console.WriteLine("Конь может ходить.");
                    }
                    else
                    {
                        Console.WriteLine("Конь не может ходить.");
                    }
                    break;
                case "ферзь":
                    if (QueenMove(xCoord_1, yCoord_1, xCoord_2, yCoord_2))
                    {
                        Console.WriteLine("Ферзь может ходить.");
                    }
                    else
                    {
                        Console.WriteLine("Ферзь не может ходить.");
                    }
                    break;

                case "слон":
                    if (BishopMove(xCoord_1, yCoord_1, xCoord_2, yCoord_2))
                    {
                        Console.WriteLine("Слон может ходить.");
                    }
                    else
                    {
                        Console.WriteLine("Слон не может ходить.");
                    }
                    break;
                default:
                    Console.WriteLine("Такой фигуры нет, выберите из предложенных!");
                    break;
            }
        }
    }
}