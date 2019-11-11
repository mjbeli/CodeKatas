using System;
using System.Text;


/*
Why an abstract class? 
The first version of this class wasn't abstract and implement all 3  of the inteface, but then I think...
 ...ok, it isn't very good that every client must to implement these 3 methods in every case.
 ... what if a client only want a different way to Print the last statement.
 ... It's sound logical that Deposit and Withdraw methods remains, but PrintStatement can change very often!
So.. Let's apply the ISP principe and use 2 different intefaces. It's a logical division!
But I don't want to expose inner variables. That breaks encapsulation --> Tell don't ask, by Martin Fowler.
So maybe a solution is to implement operations methods by default and let the clients decide how to
implement the Print method.

So here we are. I think this solution provide flexibility, encapsulation remains...
...and, everybody can decide how to print the operations.
 */
namespace BankingCode
{
    public abstract class AbstractAccount: IAccount
    {
        protected int _currentAmount = 0; // protected, so the inherint classes can use this variables
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
        
        public abstract string PrintStatement();  // Inherint classes must decide how to implement this.
    }
}
