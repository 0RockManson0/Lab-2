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
                "Выберите задачу (1-6) " +
                "или 0 для выхода:");
            choice = ConsoleHelper.ReadInt(
                "Ваш выбор: ");

            switch (choice)
            {
                case 0:
                    Console.WriteLine(
                        "Выход из программы.");
                    return;
                case 1: RunTask1(); break;
                case 2: RunTask2(); break;
                case 3: RunTask3(); break;
                case 4: RunTask4(); break;
                case 5: RunTask5(); break;
                case 6: RunTask6(); break;
                default:
                    Console.WriteLine(
                        "Неверный номер задачи.");
                    break;
            }
        }
    }

    private static void RunTask1()
    {
        Console.WriteLine(
            "\nЗадача 1: Точка");
        
        double x1 = ConsoleHelper.ReadDouble(
            "Точка 1. Введите X: ");
        double y1 = ConsoleHelper.ReadDouble(
            "Точка 1. Введите Y: ");
        Point p1 = new Point(x1, y1);

        double x2 = ConsoleHelper.ReadDouble(
            "Точка 2. Введите X: ");
        double y2 = ConsoleHelper.ReadDouble(
            "Точка 2. Введите Y: ");
        Point p2 = new Point(x2, y2);

        double x3 = ConsoleHelper.ReadDouble(
            "Точка 3. Введите X: ");
        double y3 = ConsoleHelper.ReadDouble(
            "Точка 3. Введите Y: ");
        Point p3 = new Point(x3, y3);

        Console.WriteLine(
            "\nТекстовое представление:");
        Console.WriteLine("1: " + p1);
        Console.WriteLine("2: " + p2);
        Console.WriteLine("3: " + p3);
    }

    private static void RunTask2()
    {
        Console.WriteLine(
            "\n--- Задача 2: Прямая ---");
        
        Point p1 = new Point(1, 3);
        Point p2 = new Point(23, 8);
        Line line1 = new Line(p1, p2);

        Point p3 = new Point(5, 10);
        Point p4 = new Point(25, 10);
        Line line2 = new Line(p3, p4);

        // Линия 3 ссылается на те же точки
        Line line3 = new Line(
            line1.Start, line2.End);

        Console.WriteLine(
            "\nНачальное состояние:");
        Console.WriteLine("Линия 1: " + line1);
        Console.WriteLine("Линия 2: " + line2);
        Console.WriteLine("Линия 3: " + line3);

        // Пункт 4: меняем координаты внутри точек
        line1.Start.X = 10;
        line2.End.Y = 20;

        Console.WriteLine(
            "\nПосле изменения координат " +
            "точек (пункт 4):");
        Console.WriteLine("Линия 1: " + line1);
        Console.WriteLine("Линия 2: " + line2);
        Console.WriteLine("Линия 3: " + line3);

        // Пункт 5: переприсваиваем ссылку
        line1.Start = new Point(99, 99);

        Console.WriteLine(
            "\nПосле переприсваивания " +
            "ссылки (пункт 5):");
        Console.WriteLine("Линия 1: " + line1);
        Console.WriteLine("Линия 2: " + line2);
        Console.WriteLine("Линия 3: " + line3);
    }

    private static void RunTask3()
    {
        Console.WriteLine(
            "\n--- Задача 3: Студент ---");
        
        int[] vasyaGrades = { 3, 4, 5 };
        Student vasya = new Student(
            "Вася", vasyaGrades);

        // Пункт 2: копируем ссылку на массив
        Student petya = new Student("Петя");
        petya.Grades = vasya.Grades;

        // Пункт 3: меняем оценку Пети
        petya.Grades[0] = 5;

        Console.WriteLine(
            "\nПосле изменения оценки Пети:");
        Console.WriteLine(vasya);
        Console.WriteLine(petya);
        Console.WriteLine(
            "Объяснение: Массивы — " +
            "ссылочные типы. Присвоив " +
            "petya.Grades = vasya.Grades, " +
            "мы сделали так, что оба " +
            "студента ссылаются на один " +
            "и тот же массив в памяти.");

        // Пункт 4: глубокое копирование
        Student andrey = new Student("Андрей");
        int[] andreyGrades = 
            new int[vasya.Grades.Length];
        for (int i = 0; 
            i < vasya.Grades.Length; i++)
        {
            andreyGrades[i] = vasya.Grades[i];
        }
        andrey.Grades = andreyGrades;

        vasya.Grades[0] = 2;

        Console.WriteLine(
            "\nПосле глубокого копирования " +
            "и изменения оценки Васи:");
        Console.WriteLine(vasya);
        Console.WriteLine(andrey);
    }

    private static void RunTask4()
    {
        Console.WriteLine(
            "\n--- Задача 4: Создаем Точку ---");
        
        Point p1 = new Point(3, 5);
        Point p2 = new Point(25, 6);
        Point p3 = new Point(7, 8);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
    }

    private static void RunTask5()
    {
        Console.WriteLine(
            "\n--- Задача 5: Создаем " +
            "Студента ---");
        
        int[] grades = { 3, 4, 5 };
        Student vasya = new Student(
            "Вася", grades);
        Student maxim = new Student("Максим");

        Console.WriteLine(vasya);
        Console.WriteLine(maxim);
    }

    private static void RunTask6()
    {
        Console.WriteLine(
            "\n--- Задача 6: Студент " +
            "отличник ---");
        
        int[] grades1 = { 3, 4, 5, 4 };
        Student vasya = new Student(
            "Вася", grades1);

        int[] grades2 = { 5, 5, 5, 5 };
        Student petya = new Student(
            "Петя", grades2);

        Console.WriteLine(vasya);
        Console.WriteLine(
            "Средний балл: " + 
            vasya.GetAverageGrade());
        Console.WriteLine(
            "Отличник: " + vasya.IsExcellent());

        Console.WriteLine(petya);
        Console.WriteLine(
            "Средний балл: " + 
            petya.GetAverageGrade());
        Console.WriteLine(
            "Отличник: " + petya.IsExcellent());
    }
}