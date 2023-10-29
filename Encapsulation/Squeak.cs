using System;

namespace Encapsulation
{
    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Кря-кря-кря!");
        }
    }
}