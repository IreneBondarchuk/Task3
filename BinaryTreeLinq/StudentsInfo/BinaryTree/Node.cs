using System;


namespace StudentsInfo.BinaryTree
{
    public class Node<T> : IComparable<T> where T : Student
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node<T> Parent { get; set; }


        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
            Parent = null;
        }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
    }
}
