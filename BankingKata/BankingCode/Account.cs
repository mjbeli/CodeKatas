using System;
using System.Text;

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
            StringBuilder currentStatus = new StringBuilder(); // Use stringbuilder for performnce purpose            
            currentStatus.Append(DateTime.Now.ToString("dd.MM.yyyy"));
            currentStatus.Append(" ");
            currentStatus.Append((_lastAmountModification > 0 ? "+" : string.Empty));
            currentStatus.Append(_lastAmountModification);
            currentStatus.Append(" ");
            currentStatus.Append((_currentAmount > 0 ? "+" : string.Empty));
            currentStatus.Append(_currentAmount);

            return currentStatus.ToString();
        }
    }
}
