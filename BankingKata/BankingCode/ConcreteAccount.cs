using System;
using System.Text;

namespace BankingCode
{
    public class ConcreteAccount: AbstractAccount
    {

        /// Override PrintStatement function
        public override string PrintStatement()
        {
            StringBuilder currentStatus = new StringBuilder(); // Use stringbuilder for performance purpose            
            currentStatus.Append(DateTime.Now.ToString("dd.MM.yyyy"));
            currentStatus.Append(" ");
            currentStatus.Append((base._lastAmountModification > 0 ? "+" : string.Empty));
            currentStatus.Append(base._lastAmountModification);
            currentStatus.Append(" ");
            currentStatus.Append((base._currentAmount > 0 ? "+" : string.Empty));
            currentStatus.Append(base._currentAmount);
            return currentStatus.ToString();
        }      
    }
}
