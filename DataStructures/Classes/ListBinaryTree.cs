﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheoSoft.DataStructures
{
    public class ListBinaryTree<T> : IListBinaryTree<T>
    {
        private List<T> _list;

        public int Count {  get { return _list.Count; } }

        public ListBinaryTree()
        {
            _list = new List<T>();
        }

        public void Add(T element)
        {
            _list.Add(element);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public List<T> BreadthFirstTraversal()
        {
            //Each node in order by height.
            var result = new List<T>();

            foreach (var element in _list)
                result.Add(element);

            return result;
        }

        public List<T> InOrderTraversal()
        {
            //Left, Current, Right
            var result = new List<T>();

            if (_list.Count > 0)
            {
                var index = 0;
                var stack = new Stack<int>();

                while (index != -1 || stack.Count > 0)
                {
                    while(index != -1)
                    {
                        stack.Push(index);
                        index = GetLeftChildIndex(index);
                    }

                    index = stack.Pop();
                    result.Add(_list[index]);

                    index = GetRightChildIndex(index);
                }
            }

            return result;
        }

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < _list.Count;
        }

        private int GetLeftChildIndex(int parentIndex)
        {
            int childIndex = parentIndex * 2 + 1;
            return IsValidIndex(childIndex) ? childIndex : -1;
        }

        private bool HasLeftChild(int parentIndex)
        {
            return GetLeftChildIndex(parentIndex) != -1;
        }

        private int GetRightChildIndex(int parentIndex)
        {
            int childIndex = parentIndex * 2 + 2;
            return IsValidIndex(childIndex) ? childIndex : -1;
        }

        private bool HasRightChild(int parentIndex)
        {
            return GetRightChildIndex(parentIndex) != -1;
        }

        private int GetParentIndex(int childIndex)
        {
            int parentIndex = (childIndex - 1) / 2;
            return IsValidIndex(parentIndex) ? parentIndex : -1;
        }
    }
}