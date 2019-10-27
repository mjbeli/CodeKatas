using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingCode.Test
{
    [TestClass]
    public class AccountTest
    {
        IAccount accountOperator = new Account();


        [TestMethod]
        public void PrintInitialAmountTest()
        {
            string statement = accountOperator.PrintStatement();
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " 0 0";
            Assert.AreEqual(statement, expectedStatement);
        }
        
        [TestMethod]
        public void DepositNegativeAmountTest()
        {
            string preStatement = accountOperator.PrintStatement();
            accountOperator.Deposit(-1);
            string postStatement = accountOperator.PrintStatement(); 
            Assert.AreEqual(preStatement, postStatement);           
        }
        
    }
}
