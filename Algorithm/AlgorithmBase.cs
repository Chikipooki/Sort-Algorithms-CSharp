﻿using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class AlgorithmBase<T> where T: IComparable
    {
        public List<T> Items { get; set; } = new List<T>();

        /// <summary>
        /// Сравнивает текущий экземпляр с другим объектом того же типа и меняет местами текущий и другой объект.  
        /// </summary>
        /// <param name="positionA">Первый объект типа int </param>
        /// <param name="positionB">Второй объект типа int </param>
        protected void Swop(int positionA, int positionB)
        {
            if(positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }

        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
