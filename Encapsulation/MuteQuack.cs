﻿using System;

namespace Encapsulation
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Я не крякаяю.");
        }
    }
}