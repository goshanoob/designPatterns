using System;

namespace FactoryMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYPizzaStore();
            pizzaStore.OrderPizza(PizzaTypes.Cheese);
            Console.WriteLine("DONE!");
        }
    }
}