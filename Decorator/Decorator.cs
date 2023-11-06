namespace Decorator
{
    public abstract class Decorator : Beverage
    {
        protected Beverage beverage;

        public abstract override float GetCost();
    }
}