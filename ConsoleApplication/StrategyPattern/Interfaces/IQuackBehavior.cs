﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces
{
    /// <summary>
    /// The interface that all Quack behaviors implement.
    /// </summary>
    public interface IQuackBehavior
    {
        void Quack();
    }
}
