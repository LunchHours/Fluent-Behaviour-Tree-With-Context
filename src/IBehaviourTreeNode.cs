﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentBehaviourTree
{
    /// <summary>
    /// Interface for behaviour tree nodes.
    /// </summary>
    public interface IBehaviourTreeNode<T>
    {
        /// <summary>
        /// Update the state of the behaviour tree.
        /// </summary>
        BehaviourTreeStatus Tick(T context);
    }
}
