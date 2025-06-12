

namespace Test_Gergana_12._06._2025
{
    internal class Program
    {
        public class BankAccount
        {
            public int ID;
            private double Balance;

            public void Deposit(double amount)
            {
                Balance += amount;
            }
            public void Withdraw(double amount)
            {
                Balance -= amount;
            }
            public override string ToString()
            {
                return $"Account ID: {ID}, balance: {Balance:F2}";
            }


            static void Main(string[] args)
            {
                BankAccount acc = new BankAccount();
                acc.ID = 1;
                acc.Deposit(15);
                acc.Withdraw(5);

                System.Console.WriteLine(acc.ToString());
            }
        }
    }
}
