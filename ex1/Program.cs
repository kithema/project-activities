namespace pp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            third();
            fourth();
            fifth();
            sixth();
        }
        static void first()
        {
            for (int i = 11; i < 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
        static void second()
        {
            int count = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void third()
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                x += n;
            }
            Console.Write(x);
        }
        static void fourth()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
        static void fifth()
        {
            bool end = false;
            Console.WriteLine("Введите пароль(13)");
            for (; !end;)
            {
                try
                {
                    int password = int.Parse(Console.ReadLine());
                    if (password == 13)
                    {
                        Console.WriteLine("Окау");
                        end = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
        }
        static void sixth()
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            int sum = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());
                    sum += digit * digit;
                }
            }

            Console.WriteLine($"Сумма квадратов цифр: {sum}");
            Console.ReadKey();
        }
    }
}
