using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Behaviors.QuackBehaviors
{
    /// <summary>
    /// Quack behavior for ducks that Quack.
    /// </summary>
    public class Quack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
