namespace DecoratorPattern.Decorator
{
    public class Beer : BeverageComponent
    {
        public Beer()
        {
            _description = "Cerveza";
        }
        public override double getCost() => 2.5;
    }
}