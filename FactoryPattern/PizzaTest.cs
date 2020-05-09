using Xunit;
using System;
using FactoryPattern.Business.Interfaces;
using FactoryPattern.Factory;

namespace Pizza.Test
{
    public class PizzaTest : IDisposable
    {

        public void Dispose()
        {
            // This code executes every time after a test. In xUnit Dispose is like [TestCleanup] in MSTest.
        }

        [Fact]
        public void CreateMargaritaPizza() // Facts cann't receive parameters
        {
            IPizza p = new PizzaFactory().CreatePizza(PizzaTypes.MargarinaPizza);
            Assert.True(p != null && p.PizzaDescription() == "Margarina pizza");
        }

        [Fact]
        public void CreateBBqPizza() // Facts cann't receive parameters
        {
            IPizza p = new PizzaFactory().CreatePizza(PizzaTypes.BbqPizza);
            Assert.True(p != null && p.PizzaDescription() == "Barbacue pizza");
        }
    } // end class FactoryPatternTest

}