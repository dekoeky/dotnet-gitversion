
using library;

ITimePrinter time = new TimePrinter();

while(true)
{
    time.Print();
    await Task.Delay(1000);
}