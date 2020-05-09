namespace FactoryPattern.Business.Implementations
{
    using Interfaces;

    public class MargarinaPizzaImplementation : IPizza
    {
        public string PizzaDescription()
        {
            return "Margarina pizza";
        }
    }
}