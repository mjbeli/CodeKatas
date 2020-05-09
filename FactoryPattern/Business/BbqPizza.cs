namespace FactoryPattern.Business.Implementations
{
    using Interfaces;

    public class BbqPizzaImplementation : IPizza
    {
        public string PizzaDescription()
        {
            return "Barbacue pizza";
        }
    }
}