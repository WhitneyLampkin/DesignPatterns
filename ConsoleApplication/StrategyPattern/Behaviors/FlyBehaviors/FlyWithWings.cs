using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Behaviors
{
    /// <summary>
    /// Fly behavior implementation for ducks that DO fly.
    /// </summary>
    internal class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying.");
        }
    }
}
