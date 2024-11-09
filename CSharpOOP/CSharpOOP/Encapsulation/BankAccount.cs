namespace CSharpOOP.Encapsulations
{
    internal class BankAccount
    {
        private decimal _balance; 

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
