using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.accountNumber = "1234567890";

        account.Deposit(500);
        account.Withdraw(200);
        account.Withdraw(400);
    }
}