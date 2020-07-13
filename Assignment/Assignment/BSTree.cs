using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
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

        }

        public int Height()
        {
            return height(root);
        }

        private int height(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }

            else
                return 1 + Math.Max(height(tree.Left), height(tree.Right));
        }

        public int Count()
        {
            return count(root);
        }

        private int count(Node<T> tree)
        {
            int num = 0;

            if (tree == null)
            {
                return 0;
            }

            else
            {
                num++;
                num += count(tree.Left);
                num += count(tree.Right);
            }

            return num;
        }


        public Boolean Contain(T item)
        {
            return contain(item, root);
        }


        private Boolean contain(T item, Node<T> tree)
        {
            if (tree == null)
                return false;

            else if (item.CompareTo(tree.Data) < 0)
            {
                if (tree.Left == null)
                {
                    return false;
                }
                else
                    return contain(item, tree.Left);
            }

            else if (item.CompareTo(tree.Data) > 0)
            {
                if (tree.Right == null)
                {
                    return false;
                }

                else
                    return contain(item, tree.Right);
            }

            return true;
        }



        public void RemoveItem(Company c)
        {
            removeItem(c, ref root);
        }



        private void removeItem(Company c, ref Node<T> tree)
        {
            if (tree != null)
            {

                if (c.CompareTo(tree.Data) < 0)
                {
                    removeItem(c, ref tree.Left);
                }


                if (c.CompareTo(tree.Data) > 0)
                {
                    removeItem(c, ref tree.Right);
                }


                if (c.CompareTo(tree.Data) == 0)
                {

                    if (tree.Right != null && tree.Left != null)
                    {
                        T newRoot = leastItem(tree.Right);
                        tree.Data = newRoot;
                        removeItem(c, ref tree.Right);
                    }


                    if (tree.Left == null && tree.Right != null)
                    {
                        tree = tree.Right;
                    }


                    if (tree.Right == null && tree.Left != null)
                    {
                        tree = tree.Left;
                    }


                    if (tree.Right == null && tree.Left == null)
                    {
                        tree = null;
                    }


                }

            }
           

        }

        T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }

            else
                return leastItem(tree.Left);

        }



    }

}