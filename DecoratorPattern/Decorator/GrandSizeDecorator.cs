namespace DecoratorPattern.Decorator
{
    public class GrandSizeDecorator : BeverageDecorator
    {
        public GrandSizeDecorator(BeverageComponent beverage) : base(beverage)
        {
        }

        public override string getDescription() => _description += ", tamaño grande";
        public override double getCost() => _beverage.getCost() + 1.75;
        
    }
}