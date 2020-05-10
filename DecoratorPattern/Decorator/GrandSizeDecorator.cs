namespace DecoratorPattern.Decorator
{
    public class GrandSizeDecorator : BeverageDecorator
    {
        public GrandSizeDecorator(BeverageComponent beverage) : base(beverage)
        {
            _description = beverage.getDescription() + ", tamaño grande";
        }

        public override double getCost() => _beverage.getCost() + 1.75;
        
    }
}