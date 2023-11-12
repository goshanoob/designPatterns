using System;

namespace FactoryMethod
{
    public class NYStyleCheesePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake NY Style Cheese Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut NY Style cheese Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box NY Style cheese Pizza");
        }

        public void Deliver()
        {
            Console.WriteLine("Deliver NY Style cheese Pizza");
        }
    }
}