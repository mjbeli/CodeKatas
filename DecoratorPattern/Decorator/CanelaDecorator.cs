namespace DecoratorPattern.Decorator
{
    public class CanelaDecorator : BeverageDecorator
    {
        public CanelaDecorator(BeverageComponent beverage) : base(beverage)
        {
        }

        public override string getDescription() => _description += ", con canela";
        public override double getCost() => _beverage.getCost() + 0.15;
        
    }
}