﻿namespace SortTypes.Models
{
    using System;
    using System.Collections.Generic;

    using Strategy.Common;

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class QuickSort<T> : SortStrategy<T>
    {
        public override void Sort(IEnumerable<T> collection)
        {
            Console.WriteLine(PrintMessages.SortAlgorithm, nameof(QuickSort<T>));
        }
    }
}
