using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Abstrations;

namespace BankingCode.Test
{
    [TestClass]
    public class AccountTest
    {
        private Account _accountOperator = null;
        
        // DRY, let's encapsulate this
        [TestInitialize]
        public void GetAccountOperatorFromFactory() // Must be public. Framework is looking for public methods.
        {
            _accountOperator = AccountFactory.getAccountObject(AccountType.StandardAccountType);
        }

        [TestMethod]
        public void PrintInitialAmountTest()
        {
            string statement = _accountOperator.PrintStatement();
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " 0 0";
            Assert.AreEqual(statement, expectedStatement);
        }
        
        [TestMethod]
        public void DepositNegativeAmountTest()
        {           
            string preStatement = _accountOperator.PrintStatement();
            _accountOperator.Deposit(-1);
            string postStatement = _accountOperator.PrintStatement(); 
            Assert.AreEqual(preStatement, postStatement);           
        }

        [TestMethod]
        public void DepositAmountTest()
        {           
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " +100 " + "+100";
            _accountOperator.Deposit(100);
            string postStatement = _accountOperator.PrintStatement(); 
            Assert.AreEqual(postStatement, expectedStatement);           
        }

        [TestMethod]
        public void WithdrawAmountTest()
        {        
            _accountOperator.Deposit(100);
            _accountOperator.Withdraw(30);
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " -30 " + "+70";
            string postStatement = _accountOperator.PrintStatement(); 
            Assert.AreEqual(postStatement, expectedStatement);           
        }

        [TestMethod]
        public void ShowLastPositiveOperationTest()
        {
            string expectedLasOperation = "+3100";
            _accountOperator.Deposit(100);
            _accountOperator.Deposit(500);
            _accountOperator.Deposit(3100);            
            string currentStatement = _accountOperator.PrintStatement();             
            Assert.IsTrue(currentStatement.LastIndexOf(expectedLasOperation) > 0);              
        }

        [TestMethod]
        public void ShowLastNegativeOperationTest()
        {
            string expectedLasOperation = "-2790";          
            _accountOperator.Deposit(100);
            _accountOperator.Deposit(500);
            _accountOperator.Withdraw(2790);
            
            string currentStatement = _accountOperator.PrintStatement();             
            Assert.IsTrue(currentStatement.LastIndexOf(expectedLasOperation) > 0);              
        }

        [TestMethod]
        public void WithdrawNegativeAmountTest()
        {                      
            string preStatement = _accountOperator.PrintStatement();
            _accountOperator.Withdraw(-1);
            string postStatement = _accountOperator.PrintStatement(); 
            Assert.AreEqual(preStatement, postStatement);           
        }

        [TestMethod]
        public void NegativeBalanceTest()
        {
            _accountOperator.Withdraw(100);
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " -100 " + "-100";
            string postStatement = _accountOperator.PrintStatement(); 
            Assert.AreEqual(postStatement, expectedStatement);             
        }

        [TestMethod]
        public void ZeroBalanceTest()
        {       
            _accountOperator.Deposit(100);
            _accountOperator.Withdraw(100);
            string expectedStatement = DateTime.Now.ToString("dd.MM.yyyy") + " -100 " + "0";
            string postStatement = _accountOperator.PrintStatement(); 
            Assert.AreEqual(postStatement, expectedStatement);             
        }

        
    }
}
