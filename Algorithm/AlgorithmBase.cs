using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public AlgorithmBase(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }

        public AlgorithmBase() { }

        public event EventHandler<Tuple<T, T>> CompareEvent;
        public event EventHandler<Tuple<int, T>> SetEvent;
        public event EventHandler<Tuple<T, T>> SwopEvent;

        public int ComparsionCount { get; protected set; } = 0;
        public List<T> Items { get; set; } = new List<T>();
        public int SwopCount { get; protected set; } = 0;

        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwopCount = 0;

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected int Compare(T a, T b)
        {
            CompareEvent?.Invoke(this, new Tuple<T, T>(a, b));
            ComparsionCount++;
            return a.CompareTo(b);
        }

        protected virtual void MakeSort()
        {
            Items.Sort();
        }

        protected void Set(int position, T item)
        {
            if (position < Items.Count)
            {
                SetEvent?.Invoke(this, new Tuple<int, T>(position, item));

                Items[position] = item;
            }
        }

        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                SwopEvent?.Invoke(this, new Tuple<T, T>(Items[positionA], Items[positionB]));
                SwopCount++;

                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }
    }
}