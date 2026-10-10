using System;

internal class Student
{
    // ==========================================
    // 1. ПОЛЯ
    // ==========================================
    private string _name;
    private int[] _grades;

    // ==========================================
    // 2. КОНСТРУКТОРЫ
    // ==========================================
    
    // Единственный конструктор с опциональным 
    // параметром оценок
    public Student(string name, int[] grades = null)
    {
        Name = name;
        Grades = grades;
    }

    // Конструктор копирования (глубокий)
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

    // ==========================================
    // 3. СВОЙСТВА
    // ==========================================
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
                _grades = value;
            }
        }
    }

    // ==========================================
    // 4. МЕТОДЫ
    // ==========================================
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