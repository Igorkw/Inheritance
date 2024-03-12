namespace Heranca.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; } //private só pode sera alterado pela própria classe
        public double Balance { get; protected set; } //protected: o saldo só pode ser alterado pela classe ou subclasse

        public Account() 
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
