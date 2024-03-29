﻿using Algorithm.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public void BaseSortTest()
        {
            //arrenge
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(Items);

            //act
            bases.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bases.Items[i]);
            }
        }

        [TestMethod()]
        public void BubbleSortTest()
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
        public void ShakerSortTest()
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
        public void InsertionSortTest()
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
        public void ShellSortTest()
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

        [TestMethod()]
        public void TreeSortTest()
        {
            //arrenge
            var tree = new Tree<int>(Items);

            //act
            tree.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);
            }
        }

        [TestMethod()]
        public void HeapSortTest()
        {
            // arrange
            var heap = new Heap<int>(Items);

            // act
            heap.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            //arrenge
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(Items);

            //act
            selection.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], selection.Items[i]);
            }
        }

        [TestMethod()]
        public void GnomeSortTest()
        {
            //arrenge
            var gnome = new GnomeSort<int>();
            gnome.Items.AddRange(Items);

            //act
            gnome.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], gnome.Items[i]);
            }
        }

        [TestMethod()]
        public void LsdRedixSortTest()
        {
            //arrenge
            var lsdRedix = new LsdRedixSort<int>();
            lsdRedix.Items.AddRange(Items);

            //act
            lsdRedix.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], lsdRedix.Items[i]);
            }
        }

        [TestMethod()]
        public void MsdRedixSortTest()
        {
            //arrenge
            var msdRedix = new MsdRedixSort<int>();
            msdRedix.Items.AddRange(Items);

            //act
            msdRedix.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], msdRedix.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            //arrenge
            var merge = new MergeSort<int>();
            merge.Items.AddRange(Items);

            //act
            merge.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            //arrenge
            var quick = new QuickSort<int>();
            quick.Items.AddRange(Items);

            //act
            quick.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], quick.Items[i]);
            }
        }
    }
}