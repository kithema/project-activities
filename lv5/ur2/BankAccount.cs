class BankAccount
{
    public string accountNumber;
    public double balance = 0;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Внесено {amount}. Текущий баланс: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Недостаточно средств");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Снято {amount}. Текущий баланс: {balance}");
        }
    }
}