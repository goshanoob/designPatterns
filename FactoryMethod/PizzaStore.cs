namespace FactoryMethod
{
    public abstract class PizzaStore
    {
        protected abstract IPizza CreatePizza(PizzaTypes type);

        public void OrderPizza(PizzaTypes type)
        {
            IPizza pizza = CreatePizza(type);
            
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            pizza.Deliver();
        }
    }
}