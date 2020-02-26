

using Abstrations;

namespace BankingCode
{
    public enum AccountType {StandardAccountType};

    public static class AccountFactory
    {        
        public static Account getAccountObject(AccountType accountType)
        {
            if(accountType == AccountType.StandardAccountType)
                return new ConcreteAccount();
            
            return null;
        }

    }
}