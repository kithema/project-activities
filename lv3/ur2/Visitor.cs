class Visitor
{
    public string name;
    public static int totalVisitors = 0;

    public Visitor(string visitorName)
    {
        name = visitorName;
        totalVisitors++;
    }

    public void PrintInfo()
    {
        Console.WriteLine(name);
    }

    public static void ShowTotalVisitors()
    {
        Console.WriteLine($"Всего создано посетителей: {totalVisitors}");
    }
}