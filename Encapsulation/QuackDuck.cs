using System;

namespace Encapsulation
{
    public class QuackDuck : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Кряяя!");
        }
    }
}