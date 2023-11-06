namespace Decorator
{
    public class DarkRoast : Beverage
    {
        private const float COST = 0.99f;

        public DarkRoast()
        {
            description = "Кофе темной обжарки. ";
        }
        
        public override float GetCost()
        {
            return COST;
        }
    }
}