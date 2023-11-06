namespace Decorator
{
    public class MochaDecorator : Decorator
    {
        private const float COST = 0.2f;

        public MochaDecorator(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.GetDescription() + "Шоколад. ";
        }
        
        public override float GetCost()
        {
            return beverage.GetCost() + COST;
        }
    }
}