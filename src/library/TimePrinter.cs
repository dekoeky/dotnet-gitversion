using System.ComponentModel;
using System.Diagnostics;

namespace library;

public class TimePrinter : ITimePrinter
{
    private readonly DateTimeKind kind;

    public TimePrinter(DateTimeKind kind = DateTimeKind.Local)
    {
        if (kind == DateTimeKind.Unspecified) throw new ArgumentException("The kind has to be specified", nameof(kind));
        this.kind = kind ;
    }
    public void Print()
    {
        var time = kind switch
        {
            DateTimeKind.Utc => DateTime.UtcNow,
            DateTimeKind.Local => DateTime.Now,
            _ => throw new InvalidOperationException(),
        };

        Console.WriteLine($"The time is now {time.TimeOfDay}");
    }
}
