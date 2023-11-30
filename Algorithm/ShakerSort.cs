using System;

namespace Algorithm
{
    public class ShakerSort<T> : AlgorithmBase<T> where T : IComparable 
    {
        public override void Sort()
        {
            var left = 0;
            var right = Items.Count - 1;

            while (left < right)
            {
                var preOutCounter = SwopCount;

                for (var i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);

                        ComparsionCount++;
                    }
                }
                right--;

                if (preOutCounter == SwopCount)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i-1]) == -1)
                    {
                        Swop(i, i - 1);

                        ComparsionCount++;
                    }
                }
                left++;

                if (preOutCounter == SwopCount)
                {
                    break;
                }
            }
        }
    }
}
