using System;

namespace Encapsulation
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Squeak();
        }
        
        public override void PrintInfo()
        {
            Console.WriteLine("Я рыжая утка!");
        }
    }
}