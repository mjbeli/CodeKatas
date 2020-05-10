namespace DecoratorPattern.Decorator
{
    public class CanelaDecorator : BeverageDecorator
    {
        public CanelaDecorator(BeverageComponent beverage) : base(beverage)
        {
            _description = beverage.getDescription() + ", con canela";
        }

        public override double getCost() => _beverage.getCost() + 0.15;
        
    }
}