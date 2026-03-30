using System;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle1 = new Triangle(3, 4, 5);
        Triangle triangle2 = new Triangle(1, 2, 4);

        triangle1.PrintSides();
        Console.WriteLine($"Валидный: {triangle1.IsValid()}");

        triangle2.PrintSides();
        Console.WriteLine($"Валидный: {triangle2.IsValid()}");
    }
}