using System;
using System.Drawing;


namespace HW_1_1
{
    class Solution
    {
        static public void Color(string str1, string str2)
        {
            string result = str1 + str2;
            string colorMessage = "";
            ConsoleColor color = ConsoleColor.White;

            switch (result)
            {
                case "красныйкрасный":
                    colorMessage = "Получился красный цвет!";
                    color = ConsoleColor.Red;
                    break;
                case "синийкрасный":
                case "красныйсиний":
                    colorMessage = "Получился фиолетовый цвет!";
                    color = ConsoleColor.Magenta;
                    break;
                case "желтыйкрасный":
                case "красныйжелтый":
                    colorMessage = "Получился оранжевый цвет!";
                    color = ConsoleColor.DarkYellow;
                    break;
                case "синийсиний":
                    colorMessage = "Получился синий цвет!";
                    color = ConsoleColor.Blue;
                    break;
                case "синийжелтый":
                case "желтыйсиний":
                    colorMessage = "Получился зелёный цвет!";
                    color = ConsoleColor.Green;
                    break;
                case "желтыйжелтый":
                    colorMessage = "Получился желтый цвет!";
                    color = ConsoleColor.Yellow;
                    break;
                default:
                    colorMessage = "Такого цвета у нас нет, попробуйте ещё раз!";
                    break;
            }

            Console.ForegroundColor = color;
            Console.WriteLine(colorMessage);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 цвета из предложенных: 'красный', 'желтый', 'синий', чтобы смешать их.");
            Console.WriteLine("Посмотрим что у нас получится!");

            string choice1 = Console.ReadLine();
            string choice2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(choice2) || string.IsNullOrWhiteSpace(choice1))
            {
                Console.WriteLine("Одна из введённых строк пуста, попробуйте ещё раз!");

            }
            else
            {
                Color(choice1, choice2);
            }
        }
    }
}
