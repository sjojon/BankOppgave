using BankOppgave;

Bank bank = new Bank();

BankAccount account1 = new BankAccount("123456", "Ola Nordmann", 1000);
BankAccount account2 = new BankAccount("987654", "Kari Nordmann", 500);

bank.AddAccount(account1);
bank.AddAccount(account2);

bank.PrintAllAccounts();

Console.WriteLine();

account1.Deposit(500);
account2.Withdraw(200);

bank.PrintAllAccounts();

bank.FindAccount("123456");