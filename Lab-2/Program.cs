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

    private static Point ReadPoint(string prompt)
    {
        double x = ConsoleHelper.ReadDouble(
            prompt + ". Введите X: ");
        double y = ConsoleHelper.ReadDouble(
            prompt + ". Введите Y: ");
        return new Point(x, y);
    }

    private static void RunTask1()
    {
        Console.WriteLine("\nЗадача 1: Точка");
        Point p1 = ReadPoint("Точка 1");
        Point p2 = ReadPoint("Точка 2");
        Point p3 = ReadPoint("Точка 3");
        Console.WriteLine(
            "\nТекстовое представление:");
        Console.WriteLine("1: " + p1);
        Console.WriteLine("2: " + p2);
        Console.WriteLine("3: " + p3);
    }

    private static void RunTask2()
    {
        Console.WriteLine("\nЗадача 2: Прямая");
        Console.WriteLine("Линия 1");
        Point p1 = ReadPoint("Начало линии 1");
        Point p2 = ReadPoint("Конец линии 1");
        Line line1 = new Line(p1, p2);
        
        Console.WriteLine("Линия 2");
        Point p3 = ReadPoint("Начало линии 2");
        Point p4 = ReadPoint("Конец линии 2");
        Line line2 = new Line(p3, p4);
        
        Line line3 = new Line(
            line1.Start, line2.End);
        
        Console.WriteLine("\nНачальное состояние:");
        Console.WriteLine("Линия 1: " + line1);
        Console.WriteLine("Линия 2: " + line2);
        Console.WriteLine("Линия 3: " + line3);
        
        Console.WriteLine(
            "\nПункт 4: Изменение координат");
        double newX1 = ConsoleHelper.ReadDouble(
            "Новый X начала линии 1: ");
        double newY1 = ConsoleHelper.ReadDouble(
            "Новый Y начала линии 1: ");
        line1.Start.X = newX1;
        line1.Start.Y = newY1;
        
        double newX2 = ConsoleHelper.ReadDouble(
            "Новый X конца линии 2: ");
        double newY2 = ConsoleHelper.ReadDouble(
            "Новый Y конца линии 2: ");
        line2.End.X = newX2;
        line2.End.Y = newY2;
        
        Console.WriteLine(
            "\nПосле изменения координат:");
        Console.WriteLine("Линия 1: " + line1);
        Console.WriteLine("Линия 2: " + line2);
        Console.WriteLine("Линия 3: " + line3);
        
        Console.WriteLine(
            "\nПункт 5: Переприсваивание ссылки");
        double newX3 = ConsoleHelper.ReadDouble(
            "Новый X для точки: ");
        double newY3 = ConsoleHelper.ReadDouble(
            "Новый Y для точки: ");
        line1.Start = new Point(newX3, newY3);
        
        Console.WriteLine(
            "\nПосле переприсваивания:");
        Console.WriteLine("Линия 1: " + line1);
        Console.WriteLine("Линия 2: " + line2);
        Console.WriteLine("Линия 3: " + line3);
    }

    private static void RunTask3()
    {
        Console.WriteLine("\nЗадача 3: Студент");
        Console.WriteLine("Студент 1");
        string name1 = ConsoleHelper.ReadString(
            "Имя: ");
        int[] grades1 = ConsoleHelper.ReadGrades(
            "Оценки: ");
        Student student1 = new Student(
            name1, grades1);
        
        Console.WriteLine("Студент 2");
        string name2 = ConsoleHelper.ReadString(
            "Имя: ");
        Student student2 = new Student(name2);
        student2.Grades = student1.Grades;
        
        Console.WriteLine(
            "Изменение оценки Студента 2");
        int newGrade2 = ConsoleHelper.ReadInt(
            "Новая первая оценка (2-5): ");
        student2.Grades[0] = newGrade2;
        
        Console.WriteLine(
            "\nПосле изменения " +
            "(поверхностное копирование):");
        Console.WriteLine(student1);
        Console.WriteLine(student2);
        
        Console.WriteLine("Студент 3");
        string name3 = ConsoleHelper.ReadString(
            "Имя: ");
        int[] deepCopyGrades = 
            new int[student1.Grades.Length];
        for (int i = 0; 
            i < student1.Grades.Length; i++)
        {
            deepCopyGrades[i] = student1.Grades[i];
        }
        Student student3 = new Student(
            name3, deepCopyGrades);
        
        Console.WriteLine(
            "Изменение оценки Студента 1");
        int newGrade1 = ConsoleHelper.ReadInt(
            "Новая первая оценка (2-5): ");
        student1.Grades[0] = newGrade1;
        
        Console.WriteLine(
            "\nПосле изменения " +
            "(глубокое копирование):");
        Console.WriteLine(student1);
        Console.WriteLine(student3);
    }

    private static void RunTask4()
    {
        Console.WriteLine(
            "\nЗадача 4: Создаем Точку");
        Console.WriteLine(
            "Демонстрация: конструктор " +
            "по умолчанию удален.");
        Console.WriteLine(
            "Создать точку без X и Y " +
            "невозможно.\n");
        
        // Point pInvalid = new Point(); 
        // Ошибка компиляции: Point does not 
        // contain a constructor that takes 
        // 0 arguments.

        Point p1 = ReadPoint("Точка 1");
        Point p2 = ReadPoint("Точка 2");
        Point p3 = ReadPoint("Точка 3");
        
        Console.WriteLine(
            "\nУспешно созданные точки:");
        Console.WriteLine("1: " + p1);
        Console.WriteLine("2: " + p2);
        Console.WriteLine("3: " + p3);
    }

    private static void RunTask5()
    {
        Console.WriteLine(
            "\nЗадача 5: Создаем Студента");
        Console.WriteLine("Студент 1");
        string name1 = ConsoleHelper.ReadString(
            "Имя: ");
        int[] grades1 = ConsoleHelper.ReadGrades(
            "Оценки (Enter для пропуска): ");
        Student student1 = new Student(
            name1, grades1);
        
        Console.WriteLine("Студент 2");
        string name2 = ConsoleHelper.ReadString(
            "Имя: ");
        int[] grades2 = ConsoleHelper.ReadGrades(
            "Оценки (Enter для пропуска): ");
        Student student2 = new Student(
            name2, grades2);
        
        Console.WriteLine(student1);
        Console.WriteLine(student2);
    }

    private static void RunTask6()
    {
        Console.WriteLine(
            "\nЗадача 6: Студент отличник");
        Console.WriteLine("Студент 1");
        string name1 = ConsoleHelper.ReadString(
            "Имя: ");
        int[] grades1 = ConsoleHelper.ReadGrades(
            "Оценки: ");
        Student student1 = new Student(
            name1, grades1);
        
        Console.WriteLine("Студент 2");
        string name2 = ConsoleHelper.ReadString(
            "Имя: ");
        int[] grades2 = ConsoleHelper.ReadGrades(
            "Оценки: ");
        Student student2 = new Student(
            name2, grades2);
        
        Console.WriteLine(student1);
        Console.WriteLine(
            "Средний балл: " + 
            student1.GetAverageGrade());
        Console.WriteLine(
            "Отличник: " + student1.IsExcellent());
        
        Console.WriteLine(student2);
        Console.WriteLine(
            "Средний балл: " + 
            student2.GetAverageGrade());
        Console.WriteLine(
            "Отличник: " + student2.IsExcellent());
    }
}