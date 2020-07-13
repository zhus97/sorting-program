using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment
{

    class AVLTree<T> : BSTree<T>, IEnumerable<T> where T : IComparable
    {

  

        protected int height(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }

            else
                return 1 + Math.Max(height(tree.Left), height(tree.Right));
        }






        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
            {
                //double rotate
                rotateRight(ref tree.Right);
            }



            Node<T> newRoot = tree.Right;
            tree.Right = newRoot.Left;
            newRoot.Left = tree;
            tree = newRoot;

        }






        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)
            {
                //double rotate
                rotateLeft(ref tree.Left);
            }


            Node<T> newRoot = tree.Left;
            tree.Left = newRoot.Right;
            newRoot.Right = tree;
            tree = newRoot;

        }






        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }






        private void insertItem(T item, ref Node<T> tree)
        {

            if (tree == null)
            {
                tree = new Node<T>(item);
            }

            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }

            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }


            tree.BalanceFactor = height(tree.Left) - height(tree.Right);

            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }

            if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }

        }




        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



    }


}