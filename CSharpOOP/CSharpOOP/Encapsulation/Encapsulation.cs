using CSharpOOP.Encapsulations;

namespace CSharpOOP.Encapsulation
{
    internal class Encapsulation
    {
        public static void Run()
        {
            BankAccount bankAccount = new();
            bankAccount.Deposit(100000);
            if(!bankAccount.Withdraw(5000000))
            {
                Console.WriteLine("Your balance is low");
                return;
            }

            Console.WriteLine("Withdraw Success");
            Console.WriteLine("Your balance now " + bankAccount.GetBalance());
        }
    }
}
