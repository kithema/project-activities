using System;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car
        {
            brand = "Toyota",
            model = "Camry",
            year = 2020
        };

        Car car2 = new Car
        {
            brand = "BMW",
            model = "X5",
            year = 2022
        };

        Car car3 = new Car
        {
            brand = "Lada",
            model = "Vesta"
        };

        Console.WriteLine($"Марка: {car1.brand}, Модель: {car1.model}, Год: {car1.year}");
        Console.WriteLine($"Марка: {car2.brand}, Модель: {car2.model}, Год: {car2.year}");
        Console.WriteLine($"Марка: {car3.brand}, Модель: {car3.model}, Год: {car3.year}");
    }
}