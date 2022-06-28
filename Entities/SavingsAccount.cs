namespace Projeto.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {   
            // repetindo a logica do metodo que esta em Account com a palavra "base"
            base.Withdraw(amount);

            // adicionando logica:
            Balance -= 2.0;
        }
    }
}