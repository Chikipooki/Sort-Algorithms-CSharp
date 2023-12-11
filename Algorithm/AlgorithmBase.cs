using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public int ComparsionCount { get; protected set; } = 0;
        public int SwopCount { get; protected set; } = 0;
        public List<T> Items { get; set; } = new List<T>();
        public AlgorithmBase(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }
        public AlgorithmBase() { }

        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwopCount = 0;

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected virtual void MakeSort()
        {
            Items.Sort();
        }

        /// <summary>
        /// Сравнивает текущий экземпляр с другим объектом того же типа и меняет местами текущий и другой объект.
        /// </summary>
        /// <param name="positionA">Первый объект типа int </param>
        /// <param name="positionB">Второй объект типа int </param>
        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;

                SwopCount++;
            }
        }
    }
}