﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.DataStructures
{
    public class Tree<T> : AlgorithmBase<T> where T : IComparable
    {
        public Tree(IEnumerable<T> items)
        {
            var list = items.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                Items.Add(item);

                var node = new Node<T>(item, i);
                Add(node);
            }
        }

        public Tree() { }

        public int Count { get; private set; }
        private Node<T> Root { get; set; }

        protected override void MakeSort()
        {
            var result = Inorder(Root).Select(r => r.Data).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                Set(i, result[i]);
            }
        }

        private void Add(Node<T> node)
        {
            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }

            Add(Root, node);
            Count++;
        }

        private void Add(Node<T> node, Node<T> newNode)
        {
            if (Compare(node.Data, newNode.Data) == 1)
            {
                if (node.Left == null)
                {

                    node.Left = newNode;
                }
                else
                {

                    Add(node.Left, newNode);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                }
                else
                {
                    Add(node.Right, newNode);
                }
            }
        }

        private List<Node<T>> Inorder(Node<T> node)
        {
            var list = new List<Node<T>>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }

                list.Add(node);

                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }

            return list;
        }


    }
}