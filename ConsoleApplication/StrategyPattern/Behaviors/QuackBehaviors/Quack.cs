using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Behaviors.QuackBehaviors
{
    /// <summary>
    /// Quack behavior for ducks that Quack.
    /// </summary>
    public class Quacks : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
