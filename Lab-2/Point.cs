using System;

internal class Point
{
    // ==========================================
    // 1. ПОЛЯ
    // ==========================================
    private double _x;
    private double _y;

    // ==========================================
    // 2. КОНСТРУКТОРЫ
    // ==========================================
    
    // С параметрами (основной)
    public Point(double x, double y)
    {
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
    // 3. СВОЙСТВА
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
    // 4. МЕТОДЫ
    // ==========================================
    public override string ToString()
    {
        return "{" + _x + ";" + _y + "}";
    }
}