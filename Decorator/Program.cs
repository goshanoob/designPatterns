using System;

namespace Decorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Beverage drink = new Espresso();
            Console.WriteLine(drink.GetDescription());
            Console.WriteLine(drink.GetCost());

            Console.WriteLine();
            Beverage drink2 = new DarkRoast();
            drink2 = new MochaDecorator(drink2);
            drink2 = new MochaDecorator(drink2);
            drink2 = new MochaDecorator(drink2);
            Console.WriteLine(drink2.GetDescription());
            Console.WriteLine(drink2.GetCost());
            
            Console.WriteLine();
            Beverage drink3 = new HouseBlend();
            drink3 = new MochaDecorator(drink3);
            Console.WriteLine(drink3.GetDescription());
            Console.WriteLine(drink3.GetCost());
        }
    }
}