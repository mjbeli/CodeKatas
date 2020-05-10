namespace DecoratorPattern.Decorator
{
    // In some implementations this is an interface instead an abstract class.
    public abstract class BeverageComponent
    {
        protected string _description;

        public virtual string getDescription() => _description;

        public abstract double getCost();
    }
}