using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfo.BinaryTree
{
    public class Tree<T> : IEnumerable<T> where T : Student
    {

        private Node<T> Root { get; set; }
        public int Count { get; private set; }


        public Tree()
        {
            Root = null;
        }

        public Tree(T Value)
        {
            Root = new Node<T>(Value);
        }

        public Tree(IEnumerable<T> collection)
        {
            foreach (var val in collection)
            {
                Add(val);
            }
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

        public void Add(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value");
            }

            var node = new Node<T>(value);

            if (Root == null)
                Root = node;
            else
            {
                Node<T> current = Root, parent = null;

                while (current != null)
                {
                    parent = current;
                    if (value.CompareTo(current.Value) < 0) current = current.Left;
                    else current = current.Right;
                }

                if (value.CompareTo(parent.Value) < 0) parent.Left = node;
                else parent.Right = node;
                node.Parent = parent;
            }
            ++Count;
        }



        public bool Contains(T value)
        {
            var current = Root;
            while (current != null)
            {
                var result = value.CompareTo(current.Value);
                if (result == 0) return true;
                if (result < 0) current = current.Left;
                else current = current.Right;
            }
            return false;
        }

        public void Remove(T value)
        {
            if (value == null) throw new ArgumentNullException("value");
            if (Root == null) return;

            Node<T> current = Root, parent = null;

            int result;
            do
            {
                result = value.CompareTo(current.Value);
                if (result < 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result > 0) { parent = current; current = current.Right; }
                if (current == null) return;
            }
            while (result != 0);

            if (current.Right == null)
            {
                if (current == Root) Root = current.Left;
                else
                {
                    result = current.Value.CompareTo(parent.Value);
                    if (result < 0) parent.Left = current.Left;
                    else parent.Right = current.Left;
                }
            }
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;
                if (current == Root) Root = current.Right;
                else
                {
                    result = current.Value.CompareTo(parent.Value);
                    if (result < 0) parent.Left = current.Right;
                    else parent.Right = current.Right;
                }
            }
            else
            {
                Node<T> min = current.Right.Left, prev = current.Right;
                while (min.Left != null)
                {
                    prev = min;
                    min = min.Left;
                }
                prev.Left = min.Right;
                min.Left = current.Left;
                min.Right = current.Right;

                if (current == Root) Root = min;
                else
                {
                    result = current.Value.CompareTo(parent.Value);
                    if (result < 0) parent.Left = min;
                    else parent.Right = min;
                }
            }

            --Count;
        }
        public void Clear()
        {
            Root = null;
            Count = 0;
        }

        public IEnumerable<T> InOrderEnumerator(Node<T> node)
        {
            if (Root == null) yield break;

            if (node.Left != null)
            {
                foreach (T n in InOrderEnumerator(node.Left))
                {
                    yield return n;
                }
            }
            yield return node.Value;
            if (node.Right != null)
            {
                foreach (T n in InOrderEnumerator(node.Right))
                {
                    yield return n;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InOrderEnumerator(Root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
