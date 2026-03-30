using System;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        Student student2 = new Student("Мария");
        Student student3 = new Student("Петр", 20);

        student1.PrintInfo();
        student2.PrintInfo();
        student3.PrintInfo();
    }
}