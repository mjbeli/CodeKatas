using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingCode.Test
{
    [TestClass]
    public class AccountTest
    {
        IAccount accountOperator = null;


        [TestMethod]
        public void PrintInitialAmountTest()
        {
            accountOperator = AccountFactory.getAccountObject(AccountType.StandardAccountType);
            string statement = accountOperator.PrintStatement();
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " 0 0";
            Assert.AreEqual(statement, expectedStatement);
        }
        
        [TestMethod]
        public void DepositNegativeAmountTest()
        {
            accountOperator = AccountFactory.getAccountObject(AccountType.StandardAccountType);
            string preStatement = accountOperator.PrintStatement();
            accountOperator.Deposit(-1);
            string postStatement = accountOperator.PrintStatement(); 
            Assert.AreEqual(preStatement, postStatement);           
        }

        [TestMethod]
        public void DepositAmountTest()
        {
            accountOperator = AccountFactory.getAccountObject(AccountType.StandardAccountType);
            accountOperator.Deposit(100);
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " +100 " + "+100";
            string postStatement = accountOperator.PrintStatement(); 
            Assert.AreEqual(postStatement, expectedStatement);           
        }

        [TestMethod]
        public void WithdrawAmountTest()
        {
            accountOperator = AccountFactory.getAccountObject(AccountType.StandardAccountType);
            accountOperator.Deposit(100);
            accountOperator.Withdraw(30);
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " -30 " + "+70";
            string postStatement = accountOperator.PrintStatement(); 
            Assert.AreEqual(postStatement, expectedStatement);           
        }

        [TestMethod]
        public void ShowLastPositiveOperationTest()
        {
            string expectedLasOperation = "+3100";
            accountOperator = AccountFactory.getAccountObject(AccountType.StandardAccountType);
            accountOperator.Deposit(100);
            accountOperator.Deposit(500);
            accountOperator.Deposit(3100);
            
            string currentStatement = accountOperator.PrintStatement();             
            Assert.IsTrue(currentStatement.LastIndexOf(expectedLasOperation) > 0);              
        }

        [TestMethod]
        public void ShowLastNegativeOperationTest()
        {
            string expectedLasOperation = "-2790";
            accountOperator = AccountFactory.getAccountObject(AccountType.StandardAccountType);
            accountOperator.Deposit(100);
            accountOperator.Deposit(500);
            accountOperator.Withdraw(2790);
            
            string currentStatement = accountOperator.PrintStatement();             
            Assert.IsTrue(currentStatement.LastIndexOf(expectedLasOperation) > 0);              
        }

        [TestMethod]
        public void WithdrawNegativeAmountTest()
        {
            accountOperator = AccountFactory.getAccountObject(AccountType.StandardAccountType);
            string preStatement = accountOperator.PrintStatement();
            accountOperator.Withdraw(-1);
            string postStatement = accountOperator.PrintStatement(); 
            Assert.AreEqual(preStatement, postStatement);           
        }

        [TestMethod]
        public void NegativeBalanceTest()
        {
            accountOperator = AccountFactory.getAccountObject(AccountType.StandardAccountType);
            accountOperator.Withdraw(100);
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " -100 " + "-100";
            string postStatement = accountOperator.PrintStatement(); 
            Assert.AreEqual(postStatement, expectedStatement);             
        }

        [TestMethod]
        public void ZeroBalanceTest()
        {
            accountOperator = AccountFactory.getAccountObject(AccountType.StandardAccountType);
            accountOperator.Deposit(100);
            accountOperator.Withdraw(100);
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " -100 " + "0";
            string postStatement = accountOperator.PrintStatement(); 
            Assert.AreEqual(postStatement, expectedStatement);             
        }

        
    }
}
