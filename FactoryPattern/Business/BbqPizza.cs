namespace FactoryPattern.Business.Implementations
{
    using Interfaces;

    public class BbqPizzaImplementation : IPizza
    {
        public string PizzaDescription() => "Barbacue pizza";
    }
}