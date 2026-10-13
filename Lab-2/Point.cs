using System;

internal class Point
{
    // Поля
    private double _x;
    private double _y;
    // Конструкторы
    // С параметрами (основной)
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    public Point(Point other)
    {
        if (other != null)
        {
            _x = other._x;
            _y = other._y;
        }
    }
    
    // Свойства
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
    
    // Методы
    public override string ToString()
    {
        return "{" + _x + ";" + _y + "}";
    }
}