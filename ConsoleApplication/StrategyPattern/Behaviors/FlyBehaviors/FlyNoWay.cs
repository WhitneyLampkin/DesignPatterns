using StrategyPattern.Interfaces;
using System;

namespace StrategyPattern.Behaviors
{
    /// <summary>
    /// Flying behavior implementation for ducks that do NOT fly (like rubber ducks and decoy ducks).
    /// </summary>
    internal class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
