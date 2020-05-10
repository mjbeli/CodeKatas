namespace DecoratorPattern.Decorator
{
    public class Coffee : BeverageComponent
    {
        public Coffee() : base()
        {
            _description = "Café";
        }
        public override double getCost() => 1.5;
    }
}