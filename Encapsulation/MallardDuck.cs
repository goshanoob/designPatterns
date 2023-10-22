using System;

namespace Encapsulation
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new QuackDuck();
            info = "Я утка-кряква.";
        }

        public override void PrintInfo()
        {
            Console.WriteLine(info);
        }
    }
}