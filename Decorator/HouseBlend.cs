namespace Decorator
{
    public class HouseBlend : Beverage
    {
        private const float COST = 0.89f;
            
        public override float GetCost()
        {
            return COST;
        }
    }
}