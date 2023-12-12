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
    public class SortTests
    {
        private Random rnd = new Random();
        private List<int> Items = new List<int>();
        private List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();

            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 1000));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleTest()
        {
            //arrenge
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);

            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }

        [TestMethod()]
        public void ShakerTest()
        {
            //arrenge
            var shaker = new ShakerSort<int>();
            shaker.Items.AddRange(Items);

            //act
            shaker.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shaker.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertionTest()
        {
            //arrenge
            var Insert = new InsertionSort<int>();
            Insert.Items.AddRange(Items);

            //act
            Insert.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], Insert.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellTest()
        {
            //arrenge
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);

            //act
            shell.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);
            }
        }
    }
}