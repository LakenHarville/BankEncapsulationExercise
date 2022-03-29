using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double balance;
        
        public void Deposit(double amount)
        {
            Console.WriteLine($"Depositing {amount, 0:c} to your account.");
            balance += amount; 
        }
        public double GetBalance()
        {
            return balance;
        }


    }
        
    
}
