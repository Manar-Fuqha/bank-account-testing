namespace Bank
{
    public class BankAccount
    {
        private double balance;
        public BankAccount() { }

        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public double Balance()
        {
            return balance;
        }

        public void Add(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance += amount;
        }

        public void withDraw(double amount)
        {
            if(amount > balance) throw new ArgumentOutOfRangeException(nameof(amount));
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
            
            balance -= amount;
        }

        public void TranserFundsTo( BankAccount otherAccount , double amount )
        {
            if(otherAccount is null )throw new ArgumentNullException(nameof(otherAccount));

            withDraw(amount);
            otherAccount.Add(amount);
        }
    }
}
