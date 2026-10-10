using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int choice;

        while (true)
        {
            Console.WriteLine(
                "\nЛабораторная работа №2");
            Console.WriteLine(
                "Выберите задачу (1) или 0 для выхода:");
            choice = ConsoleHelper.ReadInt(
                "Ваш выбор: ");

            switch (choice)
            {
                case 0:
                    Console.WriteLine(
                        "Выход из программы.");
                    return;
                case 1:
                    RunTask1();
                    break;
                default:
                    Console.WriteLine(
                        "Неверный номер задачи. " +
                        "Введите 1 или 0.");
                    break;
            }
        }
    }

    private static void RunTask1()
    {
        Console.WriteLine(
            "\n--- Задача 1: Точка координат ---");
        
        // Создаем три точки, используя универсальный ввод
        Point point1 = CreatePointFromInput("1");
        Point point2 = CreatePointFromInput("2");
        Point point3 = CreatePointFromInput("3");

        Console.WriteLine(
            "\nТекстовое представление точек:");
        Console.WriteLine(
            "Точка 1: " + 
            point1.GetTextRepresentation());
        Console.WriteLine(
            "Точка 2: " + 
            point2.GetTextRepresentation());
        Console.WriteLine(
            "Точка 3: " + 
            point3.GetTextRepresentation());
    }

    private static Point CreatePointFromInput(
        string name)
    {
        Console.WriteLine(
            "\nВвод данных для точки №" + name);
        
        double x = ConsoleHelper.ReadDouble(
            "Введите координату X: ");
        double y = ConsoleHelper.ReadDouble(
            "Введите координату Y: ");
        
        return new Point(x, y);
    }
}