using System;

class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(10, 20);
        (int x, int y) = point1;
        Console.WriteLine($"X: {x}, Y: {y}");

        Point point2 = new Point(5, 7);
        (_, int y2) = point2;
        Console.WriteLine($"Y: {y2}");
    }
}