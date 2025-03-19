using System;

class Solution
{


    static void Main(string[] args)
    {
        Console.WriteLine("Введите число с плавающей запятой: ");
        string userInput = Console.ReadLine();

        char[] userCharArray = userInput.ToCharArray();

        int dotIndex = Array.IndexOf(userCharArray, '.');

        if (dotIndex != -1 && dotIndex + 1 < userCharArray.Length)
        {
            char firstDigitAfterDot = userCharArray[dotIndex + 1];
            Console.WriteLine($"Первая цифра после точки: {firstDigitAfterDot}");
        }
        else
        {
            Console.WriteLine("В числе нет дробной части.");
        }

    }
}