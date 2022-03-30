namespace STimers;

public class STime
{
    /// <summary>
    /// Количество часов.
    /// </summary>
    public int Hours 
    { 
        get => hours;
        set => hours = value;
    }

    /// <summary>
    /// Количество минут.
    /// </summary>
    public int Minutes 
    { 
        get => minutes; 
        set 
        {
            if (value < 0)
            {
                Hours--;
                minutes = 60 + value;
            }

            else
            {
                minutes = value % 60;
                Hours += value / 60;
            }
        } 
    }

    /// <summary>
    /// Количество секунд.
    /// </summary>
    public int Seconds 
    { 
        get => seconds; 
        set
        {
            if (value < 0)
            {
                Minutes--;
                seconds = 60 + value;
            }

            else
            {
                seconds = value % 60;
                Minutes += value / 60;
            }
        }
    }

    /// <summary>
    /// Количество миллисекунд.
    /// </summary>
    public int Milliseconds 
    { 
        get => milliseconds; 
        set
        {
            if (value < 0)
            {
                Seconds--;
                milliseconds = 1000 + value;
            }

            else
            {
                milliseconds = value % 1000;
                Seconds += value / 1000;
            }
        }
    }

    private int hours;        // Часы.
    private int minutes;      // Минуты.
    private int seconds;      // Секунды.
    private int milliseconds; // Миллисекунды.

    /// <summary>
    /// Класс счёта времени.
    /// </summary>
    /// <param name="hours">Кол-во часов.</param>
    /// <param name="minutes">Кол-во минут.</param>
    /// <param name="seconds">Кол-во секунд.</param>
    /// <param name="milliseconds">Кол-во миллисекунд.</param>
    public STime(int hours = 0, int minutes = 0, int seconds = 0, int milliseconds = 0)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
        Milliseconds = milliseconds;
    }

    public static STime operator +(STime a, STime b) => new(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds, a.Milliseconds + b.Milliseconds);
    public static STime operator -(STime a, STime b) => new(a.Hours - b.Hours, a.Minutes - b.Minutes, a.Seconds - b.Seconds, a.Milliseconds - b.Milliseconds);
    public static STime operator *(STime a, int val) => new(a.Hours * val, a.Minutes * val, a.Seconds * val, a.Milliseconds * val);
    public static STime operator /(STime a, int val) => new(a.Hours / val, a.Minutes / val, a.Seconds / val, a.Milliseconds / val);
    public static STime operator *(int val, STime a) => a * val;

    public static bool operator >(STime a, STime b)
    {
        if (a.Hours == b.Hours)
        {
            if (a.Minutes == b.Minutes) 
            {
                if (a.Seconds == b.Seconds) return a.Milliseconds > b.Milliseconds;
                else return a.Seconds > b.Seconds;
            }
            else return a.Minutes > b.Minutes;
        }
        else return a.Hours > b.Hours;
    }
    public static bool operator <(STime a, STime b) => !(a >= b);

    public static bool operator ==(STime a, STime b)
    => a.Hours == b.Hours
    && a.Minutes == b.Minutes
    && a.Seconds == b.Seconds
    && a.Milliseconds == b.Milliseconds;
    public static bool operator !=(STime a, STime b) => !(a == b);

    public static bool operator >=(STime a, STime b) => a > b || a == b;
    public static bool operator <=(STime a, STime b) => !(a > b);

    /// <returns>Общее количество часов.</returns>
    public double ToHours() => ToMinutes() / 60;

    /// <returns>Общее количество минут.</returns>
    public double ToMinutes() => ToSeconds() / 60;

    /// <returns>Общее количество секунд.</returns>
    public double ToSeconds() => (double)ToMilliseconds() / 1000;

    /// <returns>Общее количество миллисекунд.</returns>
    public long ToMilliseconds() => ((Hours * 60 + Minutes) * 60 + Seconds) * 1000 + Milliseconds;

    /// <returns>Представление времени в виде строки.</returns>
    public override string ToString() => $"{Hours}:{Minutes}:{Seconds}:{Milliseconds}";
}
