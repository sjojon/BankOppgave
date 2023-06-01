namespace BankOppgave
{
    internal class BankAccount
    {
        public string AccountNumber { get; }
        public string Owner { get; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, string owner, decimal balance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            // TODO: Implementer innskuddsmetoden
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            // TODO: Implementer uttaksmetoden
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}\nOwner: {Owner}\nBalance: {Balance:C}";
        }
    }
}