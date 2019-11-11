// Due to the Interface Segregation Principle, let's use 2 diferents interfaces.
// More cohesive interfaces:
//      - Interface for operation purposes
//      - Interface for print purposes
public interface IAccount
{
    void Deposit(int amount);
    void Withdraw(int amount);
    string PrintStatement(); 

}