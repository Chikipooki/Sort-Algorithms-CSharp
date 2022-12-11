using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]

        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 100));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleTest()
        {
            // Arrange
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);

            // Act
            bubble.Sort();

            // Assert
            for(int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }  
        }

        [TestMethod()]
        public void ShakerTest()
        {
            // Arrange
            var shaker = new ShakerSort<int>();
            shaker.Items.AddRange(Items);

            // Act
            shaker.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shaker.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertTest()
        {
            // Arrange
            var insert = new InsertSort<int>();
            insert.Items.AddRange(Items);

            // Act
            insert.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellTest()
        {
            // Arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);

            // Act
            shell.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);
            }
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            // Arrange
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(Items);

            // Act
            bases.Sort();

            // Assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bases.Items[i]);
            }
        }
    }
}