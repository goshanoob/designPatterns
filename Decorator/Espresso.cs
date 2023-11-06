namespace Decorator
{
    public class Espresso : Beverage
    {
        private const float COST = 1.99f;

        public Espresso()
        {
            description = "Эспрессо. ";
        }
        
        public override float GetCost()
        {
            return COST;
        }
    }
}