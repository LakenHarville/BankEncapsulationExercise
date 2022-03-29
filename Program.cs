using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine($"Please make a deposit.");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);

            double userBalance = ba.GetBalance();

            Console.WriteLine($"Balance: {userBalance,0:c}");

        }
    }
}
