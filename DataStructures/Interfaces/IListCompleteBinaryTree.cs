using System;
using System.Collections.Generic;
using System.Text;

namespace TheoSoft.DataStructures
{
    public interface IListCompleteBinaryTree<T>
    {
        void Add(T element);

        void Clear();

        List<T> BreadthFirstTraversal();

        List<T> InOrderTraversal();

        List<T> ReverseInOrderTraversal();

        List<T> PreOrderTraversal();

        List<T> ReversePreOrderTraversal();
    }
}
