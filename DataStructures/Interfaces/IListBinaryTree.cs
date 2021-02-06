using System;
using System.Collections.Generic;
using System.Text;

namespace TheoSoft.DataStructures
{
    public interface IListBinaryTree<T>
    {
        void Add(T element);

        void Clear();

        List<T> BreadthFirstTraversal();

        List<T> InOrderTraversal();
    }
}
