
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Node<T> where T : IComparable
    {
        public Node<T> Left, Right;

        public Node(T item)
        {
            Data = item;
            Left = null;
            Right = null;
        }

        public T Data { set; get; }

        public int BalanceFactor { set; get; } = 0;
    }
}
