

namespace BankingCode
{
    public enum AccountType {StandardAccountType};

    public static class AccountFactory
    {        
        public static IAccount getAccountObject(AccountType accountType)
        {
            if(accountType == AccountType.StandardAccountType)
                return new Account();
            
            return null;
        }
    }
}