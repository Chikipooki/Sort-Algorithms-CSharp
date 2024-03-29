﻿using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class SelectionSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public SelectionSort(IEnumerable<T> items) : base(items) { }
        public SelectionSort() { }

        protected override void MakeSort()
        {
            for (int i = 0; i < Items.Count - 1; i++)
            {
               var minIndex = i;

                for (int j = i + 1; j < Items.Count; j++)
                {
                    if (Compare(Items[j], Items[minIndex]) == -1)
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                    Swop(i, minIndex);
            }
        }
    }
}