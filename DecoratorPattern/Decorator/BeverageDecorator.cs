namespace DecoratorPattern.Decorator
{
    public abstract class BeverageDecorator : BeverageComponent
    {
        protected BeverageComponent _beverage;
        public BeverageDecorator(BeverageComponent beverage) => this._beverage = beverage;

    }
}