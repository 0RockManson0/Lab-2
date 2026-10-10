using System;

internal class Point
{
    // ==========================================
    // 1. ПОЛЯ (Fields)
    // ==========================================
    private double _x;
    private double _y;

    // ==========================================
    // 2. КОНСТРУКТОРЫ (Constructors)
    // ==========================================
    
    // По умолчанию
    public Point()
    {
        _x = 0;
        _y = 0;
    }

    // С параметрами
    public Point(double x, double y)
    {
        // Используем свойства, чтобы сработала 
        // валидация в блоке set
        X = x;
        Y = y;
    }

    // Конструктор копирования
    public Point(Point other)
    {
        if (other != null)
        {
            _x = other._x;
            _y = other._y;
        }
    }

    // ==========================================
    // 3. СВОЙСТВА (Properties)
    // В сетах проходят все проверки
    // ==========================================
    public double X
    {
        get { return _x; }
        set
        {
            if (double.IsNaN(value) || 
                double.IsInfinity(value))
            {
                throw new ArgumentException(
                    "Координата должна быть " +
                    "конечным числом.");
            }
            _x = value;
        }
    }

    public double Y
    {
        get { return _y; }
        set
        {
            if (double.IsNaN(value) || 
                double.IsInfinity(value))
            {
                throw new ArgumentException(
                    "Координата должна быть " +
                    "конечным числом.");
            }
            _y = value;
        }
    }

    // ==========================================
    // 4. МЕТОДЫ (Methods)
    // ==========================================
    public string GetTextRepresentation()
    {
        return "{" + _x + ";" + _y + "}";
    }
}