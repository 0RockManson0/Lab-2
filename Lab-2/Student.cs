using System;

internal class Student
{
    // Поля
    private string _name;
    private int[] _grades;

    // Конструкторы
    public Student(string name, int[] grades = null)
    {
        Name = name;
        Grades = grades;
    }

    public Student(Student other)
    {
        if (other != null)
        {
            _name = other._name;
            _grades = new int[
                other._grades.Length];
            for (int i = 0; 
                i < other._grades.Length; i++)
            {
                _grades[i] = other._grades[i];
            }
        }
    }

    // Свойства
    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "Имя не может быть пустым.");
            }
            _name = value;
        }
    }

    public int[] Grades
    {
        get { return _grades; }
        set
        {
            if (value == null)
            {
                _grades = new int[0];
            }
            else
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < 2 || value[i] > 5)
                    {
                        throw new ArgumentException(
                            "Оценка должна быть " +
                            "от 2 до 5.");
                    }
                }
                _grades = value;
            }
        }
    }

    // Методы
    public double GetAverageGrade()
    {
        if (_grades.Length == 0)
        {
            return 0;
        }
        int sum = 0;
        for (int i = 0; i < _grades.Length; i++)
        {
            sum += _grades[i];
        }
        return (double)sum / _grades.Length;
    }

    public bool IsExcellent()
    {
        if (_grades.Length == 0)
        {
            return false;
        }
        for (int i = 0; i < _grades.Length; i++)
        {
            if (_grades[i] != 5)
            {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        return _name + ": " + 
            ConsoleHelper.ToString(_grades);
    }
}