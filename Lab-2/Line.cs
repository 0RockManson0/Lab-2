using System;

internal class Line
{
    // Поля
    private Point _start;
    private Point _end;

    // Конструкторы
    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public Line(Line other)
    {
        if (other != null)
        {
            _start = new Point(other._start);
            _end = new Point(other._end);
        }
    }

    // Свойства
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

    // Методы
    public override string ToString()
    {
        return "Линия от " + 
               _start.ToString() + 
               " до " + 
               _end.ToString();
    }
}