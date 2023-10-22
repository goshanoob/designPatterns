using System.Security.Authentication.ExtendedProtection;

namespace Encapsulation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var firstDuck = new MallardDuck();
            var secondDuck = new DecoyDuck();
            
            firstDuck.PrintInfo();
            firstDuck.Swim();
            firstDuck.PerformFly();
            firstDuck.PerformQuack();
            
            secondDuck.PrintInfo();
            secondDuck.Swim();
            secondDuck.PerformFly();
            secondDuck.PerformQuack();
            secondDuck.SetFlyBehaviour(new FlyWithWings());
            secondDuck.SetQuackBehaviour(new QuackDuck());
            secondDuck.PerformFly();
            secondDuck.PerformQuack();
        }
    }
}