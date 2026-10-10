using System;

internal class Line
{
    // ==========================================
    // 1. ПОЛЯ
    // ==========================================
    private Point _start;
    private Point _end;

    // ==========================================
    // 2. КОНСТРУКТОРЫ
    // ==========================================
    
    // С параметрами
    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    // Конструктор копирования (глубокий)
    public Line(Line other)
    {
        if (other != null)
        {
            _start = new Point(other._start);
            _end = new Point(other._end);
        }
    }

    // ==========================================
    // 3. СВОЙСТВА
    // ==========================================
    public Point Start
    {
        get { return _start; }
        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "Начало линии не может " +
                    "быть null.");
            }
            _start = value;
        }
    }

    public Point End
    {
        get { return _end; }
        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "Конец линии не может " +
                    "быть null.");
            }
            _end = value;
        }
    }

    // ==========================================
    // 4. МЕТОДЫ
    // ==========================================
    public override string ToString()
    {
        return "Линия от " + 
               _start.ToString() + 
               " до " + 
               _end.ToString();
    }
}