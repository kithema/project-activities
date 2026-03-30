using System;
class Program
{
    static void Main(string[] args)
    {
        Visitor visitor1 = new Visitor("Анна");
        Visitor visitor2 = new Visitor("Борис");
        Visitor visitor3 = new Visitor("Виктор");

        visitor1.PrintInfo();
        visitor2.PrintInfo();
        visitor3.PrintInfo();

        Visitor.ShowTotalVisitors();
    }
}