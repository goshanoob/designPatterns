using System;

namespace Encapsulation
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new MuteQuack();
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Я всего-лишь приманка.");
        }
    }
}