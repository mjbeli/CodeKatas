using System;

namespace BankingCode
{
    public class Account: IAccount
    {
        private int _currentAmount = 0;
        private int _lastAmountModification = 0;
        public void Deposit(int amount)
        {
            if(amount <= 0) return;
        }
        public void Withdraw(int amount)
        {

        }
        public string PrintStatement()
        {
            return DateTime.Now.ToString("dd.MM.yyyy") + " " + _lastAmountModification + " " + _currentAmount;
        }

    }
}
