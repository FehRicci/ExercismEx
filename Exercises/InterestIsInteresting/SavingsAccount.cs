using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.InterestIsInteresting
{
    internal class SavingsAccount
    {
        //3,213% para saldo negativo(saldo fica mais negativo).
        //0,5% para um saldo positivo inferior a 1000dólares.
        //1,621% para saldo positivo maior ou igual a 1000dólares e menor que 5000dólares.
        //2,475% para saldo positivo maior ou igual a 5000dólares.

        public static float InterestRate(decimal balance)
        {
            if (balance < 0)
                return 3.213f;
            else if (balance < 1000)
                return 0.5f;
            else if (balance >= 1000 && balance < 5000)
                return 1.621f;
            else if (balance >= 5000)
                return 2.475f;
            else 
                return 0.0f;
        }

        public static decimal Interest(decimal balance)
        {
            
            decimal interest = Convert.ToDecimal(InterestRate(balance));

            return (interest * balance)/100;

        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
                       return Interest(balance) + balance;
        }

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int soma = 0;
            while (balance < targetBalance)
            {
                balance = AnnualBalanceUpdate(balance);
                soma++;

            }
            return soma;

        }
    }
}
