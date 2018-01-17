using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Behaviors.QuackBehaviors
{
    public class Squeak : IQuackBehavior
    {
        /// <summary>
        /// Quack behavior for ducks that squeak.
        /// </summary>
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
