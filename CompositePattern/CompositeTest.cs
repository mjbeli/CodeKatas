using Xunit;
using CompositePattern.CompositePattern;

namespace CompositePattern.Test
{
    public class CompositePatternTest
    {

        private Employee minion1, minion2, minion3;
        EmployeeComposite middleBoss, headBoss;

        public CompositePatternTest()
        {
            minion1 = new Employee("Bob", 300.0);
            minion2 = new Employee("Jack", 200.0);
            minion3 = new Employee("Vincent", 220.0);
            middleBoss = new EmployeeComposite("Sarah", 264.0);
            headBoss = new EmployeeComposite("Jessica", 310.0);
        }

        [Fact]
        public void SimpleMinionEmployee()
        {
            Assert.True(minion1.GetEmployeeInfo() == "Mi nombre es Bob y mi salario 300");
            Assert.True(minion2.GetEmployeeInfo() == "Mi nombre es Jack y mi salario 200");
            Assert.True(minion3.GetEmployeeInfo() == "Mi nombre es Vincent y mi salario 220");
        }

        [Fact]
        public void SimpleMiddleBoss()
        {
            middleBoss.AddMinion(minion1);
            Assert.True(middleBoss.GetEmployeeInfo() == "Mi nombre es Sarah, mi salario es 264 y tengo los siguientes minions: Mi nombre es Bob y mi salario 300");
        }

        [Fact]
        public void ComplexTreeEmployees()
        {
            middleBoss.AddMinion(minion1);
            middleBoss.AddMinion(minion2);
            headBoss.AddMinion(middleBoss);
            headBoss.AddMinion(minion3);
        
            string expectedResult = "Mi nombre es Jessica, mi salario es 310 y tengo los siguientes minions: Mi nombre es Sarah, mi salario es 264 y tengo los siguientes minions: Mi nombre es Bob y mi salario 300 Mi nombre es Jack y mi salario 200 Mi nombre es Vincent y mi salario 220";

            Assert.True(headBoss.GetEmployeeInfo()==expectedResult);
        }
    }
}