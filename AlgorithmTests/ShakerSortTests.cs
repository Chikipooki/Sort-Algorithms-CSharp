using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class ShakerSortTests
    {
        [TestMethod()]
        public void SortTest()
        {

            //arrenge
            var shaker = new ShakerSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            shaker.Items.AddRange(items);
            items.Sort();

            //act
            shaker.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], shaker.Items[i]);
            }
        }
    }
}