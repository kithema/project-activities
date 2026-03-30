using System;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point();
        p1.X = 10;
        p1.Y = 20;

        Point p2;
        p2.X = 5;
        p2.Y = 15;

        p1.PrintCoordinates();
        p2.PrintCoordinates();

        p1.Move(5, -3);
        p1.PrintCoordinates();
    }
}