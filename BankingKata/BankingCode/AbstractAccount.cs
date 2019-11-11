using System;
using System.Text;

namespace BankingCode
{
    public abstract class AbstractAccount: IAccount
    {
        protected int _currentAmount = 0;
        protected int _lastAmountModification = 0;
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
        
        public abstract string PrintStatement();       
    }
}
