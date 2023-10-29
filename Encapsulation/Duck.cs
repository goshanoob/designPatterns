using System;

namespace Encapsulation
{
    public abstract class Duck
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;
        
        protected string info = "Я утка.";
        
        public abstract void PrintInfo();

        public void Swim()
        {
            Console.WriteLine("Я плаваю в воде!");
        }

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            this.quackBehaviour = quackBehaviour;
        }
    }
}