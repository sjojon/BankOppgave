namespace BankOppgave
{
    internal class Bank
    {
        private List<BankAccount> accounts;

        public Bank()
        {
            accounts = new List<BankAccount>();
        }

        public void AddAccount(BankAccount account)
        {
            // TODO: Implementer metoden for å legge til en bankkonto
            accounts.Add(account);
        }

        public void RemoveAccount(BankAccount account)
        {
            // TODO: Implementer metoden for å fjerne en bankkonto
            accounts.Remove(account);
        }

        public BankAccount FindAccount(string accountNumber)
        {
            // TODO: Implementer metoden for å finne en bankkonto basert på kontonummeret
            foreach (var account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    Console.WriteLine(account);
                    return account;
                }
            }

            return null;
        }

        public void PrintAllAccounts()
        {
            // TODO: Implementer metoden for å skrive ut informasjon om alle bankkontoene
            foreach (var account in accounts)
            {
                //Console.WriteLine($"Account number: {account.AccountNumber}\nAccount owner: {account.Owner}\nBalance: {account.Balance:C}");
                Console.WriteLine(account);
                Console.WriteLine();
            }
        }
    }
}