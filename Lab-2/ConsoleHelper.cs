using System;

internal static class ConsoleHelper
{
    public static int ReadInt(string prompt)
    {
        string input;
        int result;
        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                return result;
            }
            Console.WriteLine(
                "Некорректный ввод. " +
                "Введите целое число.");
        }
    }

    public static double ReadDouble(string prompt)
    {
        string input;
        double result;
        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (double.TryParse(
                    input, out result))
            {
                return result;
            }
            Console.WriteLine(
                "Некорректный ввод. " +
                "Введите вещественное число.");
        }
    }

    public static string ToString(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return "[]";
        }
        
        string result = "[";
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
            if (i < arr.Length - 1)
            {
                result += ", ";
            }
        }
        result += "]";
        return result;
    }
}