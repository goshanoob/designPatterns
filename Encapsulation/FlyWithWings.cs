using System;

namespace Encapsulation
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Я лечу на крыльях!");
        }
    }
}