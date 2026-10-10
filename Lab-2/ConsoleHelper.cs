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
            if (double.TryParse(input, out result))
            {
                return result;
            }
            Console.WriteLine(
                "Некорректный ввод. " +
                "Введите вещественное число.");
        }
    }

    public static long ReadLong(string prompt)
    {
        string input;
        long result;
        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (long.TryParse(input, out result))
            {
                return result;
            }
            Console.WriteLine(
                "Некорректный ввод. " +
                "Введите большое целое число.");
        }
    }

    public static int[] ReadIntArray(string prompt)
    {
        string input;
        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(
                    "Массив не может быть пустым.");
                continue;
            }

            string[] parts = input.Split(' ');
            int count = 0;
            foreach (string part in parts)
            {
                if (!string.IsNullOrWhiteSpace(part))
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            bool isValid = true;

            foreach (string part in parts)
            {
                if (!string.IsNullOrWhiteSpace(part))
                {
                    if (!int.TryParse(
                        part, out result[index]))
                    {
                        isValid = false;
                        break;
                    }
                    index++;
                }
            }

            if (isValid) return result;
            
            Console.WriteLine(
                "Некорректный ввод. " +
                "Введите числа через пробел.");
        }
    }

    public static void PrintArray(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("[]");
            return;
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
        Console.WriteLine(result);
    }
}