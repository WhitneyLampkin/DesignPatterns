using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Behaviors.QuackBehaviors
{
    /// <summary>
    /// Quack behavior for ducks that quack.
    /// </summary>
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
