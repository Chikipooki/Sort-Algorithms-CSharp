using System;

namespace Algorithm.DataStructures
{
    internal class Node<T> where T : IComparable
    {
        public Node(T data, int index)
        {
            Data = data;
            Index = index;
        }

        public T Data { get; private set; }
        public int Index { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}