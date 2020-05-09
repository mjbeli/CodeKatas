namespace FactoryPattern.Business.Implementations
{
    using Interfaces;

    public class MargarinaPizzaImplementation : IPizza
    {
        public string PizzaDescription() => "Margarina pizza";
    }
}