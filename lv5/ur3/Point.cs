struct Point
{
    public int X;
    public int Y;

    public void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }

    public void PrintCoordinates()
    {
        Console.WriteLine($"Точка: ({X}, {Y})");
    }
}