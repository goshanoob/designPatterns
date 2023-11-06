namespace Decorator
{
    public abstract class Beverage
    {
        protected string description = "Some coffee. ";

        public string GetDescription() => description;

        public abstract float GetCost();
    }
}