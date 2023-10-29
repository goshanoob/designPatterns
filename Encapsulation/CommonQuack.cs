using System;

namespace Encapsulation
{
    public class CommonQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Кряяя!");
        }
    }
}