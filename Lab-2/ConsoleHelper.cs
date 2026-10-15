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

    public static string ReadString(string prompt)
    {
        string result;
        while (true)
        {
            Console.Write(prompt);
            result = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }
            Console.WriteLine(
                "Имя не может быть пустым.");
        }
    }

    public static int[] ReadGrades(string prompt)
    {
        string input;
        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
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
                    int grade;
                    if (!int.TryParse(
                        part, out grade))
                    {
                        isValid = false;
                        break;
                    }
                    
                    if (grade < 2 || grade > 5)
                    {
                        Console.WriteLine(
                            "Оценка должна быть " +
                            "от 2 до 5.");
                        isValid = false;
                        break;
                    }
                    
                    result[index] = grade;
                    index++;
                }
            }
            
            if (isValid) return result;
            
            Console.WriteLine(
                "Введите оценки от 2 до 5 " +
                "через пробел.");
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