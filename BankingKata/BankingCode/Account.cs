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

            _lastAmountModification = amount;
            _currentAmount += amount;
        }
        public void Withdraw(int amount)
        {
            if(amount <= 0) return;

            _lastAmountModification = -1 * amount;
            _currentAmount -= amount;
        }
        public string PrintStatement()
        {
            return DateTime.Now.ToString("dd.MM.yyyy") 
                    + " " 
                    + (_lastAmountModification > 0 ? "+" : string.Empty)
                    + _lastAmountModification
                    + " " 
                    + (_currentAmount > 0 ? "+" : string.Empty)
                    + _currentAmount;
        }

    }
}
