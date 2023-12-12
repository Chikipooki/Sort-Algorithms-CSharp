using System;

namespace Algorithm
{
    public class ShakerSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var left = 0;
            var right = Items.Count - 1;

            while (left < right)
            {
                var preOutCounter = SwopCount;

                for (var i = left; i < right; i++)
                {
                    if (Compare(Items[i], (Items[i + 1])) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
                right--;

                if (preOutCounter == SwopCount)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if (Compare(Items[i], (Items[i-1])) == -1)
                    {
                        Swop(i, i - 1);
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
