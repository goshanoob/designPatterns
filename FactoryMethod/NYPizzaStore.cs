namespace FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        protected override IPizza CreatePizza(PizzaTypes type)
        {
            IPizza pizza = null;
            
            switch (type)
            {
                case PizzaTypes.Cheese:
                    pizza = new NYStyleCheesePizza();
                    break;
            }
            
            return pizza;
        }
    }
}