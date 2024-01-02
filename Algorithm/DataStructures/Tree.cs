﻿using System;
using System.Collections.Generic;

namespace Algorithm.DataStructures
{
    internal class Tree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Counter { get; private set; }

        public Tree() { }

        public Tree(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Counter = 1;
                return;
            }

            Root.Add(data);
            Counter++;
        }

        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Inorder(Root);
        }

        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }

            return list;
        }
    }
}