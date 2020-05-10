namespace DecoratorPattern.Decorator
{
    public class IceDecorator : BeverageDecorator
    {
        public IceDecorator(BeverageComponent beverage) : base(beverage)
        {
            _description = beverage.getDescription() + ", con hielo";
        }

        public override double getCost() => _beverage.getCost() + 0.5;
        
    }
}