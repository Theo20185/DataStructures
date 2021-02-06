using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheoSoft.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheoSoft.DataStructures.Tests
{
    [TestClass()]
    public class ListCompleteBinaryTreeTests
    {
        [TestMethod()]
        public void BreadthFirstTraversalTest()
        {
            var listBinaryTree = new ListCompleteBinaryTree<int>();

            listBinaryTree.Add(1);
            listBinaryTree.Add(2);
            listBinaryTree.Add(3);
            listBinaryTree.Add(4);
            listBinaryTree.Add(5);
            listBinaryTree.Add(6);
            listBinaryTree.Add(7);
            listBinaryTree.Add(8);

            //1
            //2,    3
            //4, 5, 6, 7
            //8

            var breadthFirstTraversalList = listBinaryTree.BreadthFirstTraversal();

            Assert.IsTrue(breadthFirstTraversalList.Count == 8);
            Assert.IsTrue(breadthFirstTraversalList[0] == 1);
            Assert.IsTrue(breadthFirstTraversalList[1] == 2);
            Assert.IsTrue(breadthFirstTraversalList[2] == 3);
            Assert.IsTrue(breadthFirstTraversalList[3] == 4);
            Assert.IsTrue(breadthFirstTraversalList[4] == 5);
            Assert.IsTrue(breadthFirstTraversalList[5] == 6);
            Assert.IsTrue(breadthFirstTraversalList[6] == 7);
            Assert.IsTrue(breadthFirstTraversalList[7] == 8);

            listBinaryTree.Clear();

            listBinaryTree.Add(1);

            breadthFirstTraversalList = listBinaryTree.BreadthFirstTraversal();

            Assert.IsTrue(breadthFirstTraversalList.Count == 1);
            Assert.IsTrue(breadthFirstTraversalList[0] == 1);

            listBinaryTree.Clear();

            breadthFirstTraversalList = listBinaryTree.BreadthFirstTraversal();

            Assert.IsTrue(breadthFirstTraversalList.Count == 0);
        }

        [TestMethod()]
        public void InOrderTraversalTest()
        {
            var listBinaryTree = new ListCompleteBinaryTree<int>();

            listBinaryTree.Add(1);
            listBinaryTree.Add(2);
            listBinaryTree.Add(3);
            listBinaryTree.Add(4);
            listBinaryTree.Add(5);
            listBinaryTree.Add(6);
            listBinaryTree.Add(7);
            listBinaryTree.Add(8);

            //1
            //2,    3
            //4, 5, 6, 7
            //8

            var inOrderTraversalList = listBinaryTree.InOrderTraversal();

            Assert.IsTrue(inOrderTraversalList.Count == 8);
            Assert.IsTrue(inOrderTraversalList[0] == 8);
            Assert.IsTrue(inOrderTraversalList[1] == 4);
            Assert.IsTrue(inOrderTraversalList[2] == 2);
            Assert.IsTrue(inOrderTraversalList[3] == 5);
            Assert.IsTrue(inOrderTraversalList[4] == 1);
            Assert.IsTrue(inOrderTraversalList[5] == 6);
            Assert.IsTrue(inOrderTraversalList[6] == 3);
            Assert.IsTrue(inOrderTraversalList[7] == 7);

            listBinaryTree.Clear();

            listBinaryTree.Add(1);

            inOrderTraversalList = listBinaryTree.InOrderTraversal();

            Assert.IsTrue(inOrderTraversalList.Count == 1);
            Assert.IsTrue(inOrderTraversalList[0] == 1);

            listBinaryTree.Clear();

            inOrderTraversalList = listBinaryTree.InOrderTraversal();

            Assert.IsTrue(inOrderTraversalList.Count == 0);
        }

        [TestMethod()]
        public void ReverseInOrderTraversalTest()
        {
            var listBinaryTree = new ListCompleteBinaryTree<int>();

            listBinaryTree.Add(1);
            listBinaryTree.Add(2);
            listBinaryTree.Add(3);
            listBinaryTree.Add(4);
            listBinaryTree.Add(5);
            listBinaryTree.Add(6);
            listBinaryTree.Add(7);
            listBinaryTree.Add(8);

            //1
            //2,    3
            //4, 5, 6, 7
            //8

            var reverseInOrderTraversalList = listBinaryTree.ReverseInOrderTraversal();

            Assert.IsTrue(reverseInOrderTraversalList.Count == 8);
            Assert.IsTrue(reverseInOrderTraversalList[0] == 7);
            Assert.IsTrue(reverseInOrderTraversalList[1] == 3);
            Assert.IsTrue(reverseInOrderTraversalList[2] == 6);
            Assert.IsTrue(reverseInOrderTraversalList[3] == 1);
            Assert.IsTrue(reverseInOrderTraversalList[4] == 5);
            Assert.IsTrue(reverseInOrderTraversalList[5] == 2);
            Assert.IsTrue(reverseInOrderTraversalList[6] == 4);
            Assert.IsTrue(reverseInOrderTraversalList[7] == 8);

            listBinaryTree.Clear();

            listBinaryTree.Add(1);

            reverseInOrderTraversalList = listBinaryTree.ReverseInOrderTraversal();

            Assert.IsTrue(reverseInOrderTraversalList.Count == 1);
            Assert.IsTrue(reverseInOrderTraversalList[0] == 1);

            listBinaryTree.Clear();

            reverseInOrderTraversalList = listBinaryTree.ReverseInOrderTraversal();

            Assert.IsTrue(reverseInOrderTraversalList.Count == 0);
        }

        [TestMethod()]
        public void PreOrderTraversalTest()
        {
            var listBinaryTree = new ListCompleteBinaryTree<int>();

            listBinaryTree.Add(1);
            listBinaryTree.Add(2);
            listBinaryTree.Add(3);
            listBinaryTree.Add(4);
            listBinaryTree.Add(5);
            listBinaryTree.Add(6);
            listBinaryTree.Add(7);
            listBinaryTree.Add(8);

            //1
            //2,    3
            //4, 5, 6, 7
            //8

            var preOrderTraversalList = listBinaryTree.PreOrderTraversal();

            Assert.IsTrue(preOrderTraversalList.Count == 8);
            Assert.IsTrue(preOrderTraversalList[0] == 1);
            Assert.IsTrue(preOrderTraversalList[1] == 2);
            Assert.IsTrue(preOrderTraversalList[2] == 4);
            Assert.IsTrue(preOrderTraversalList[3] == 8);
            Assert.IsTrue(preOrderTraversalList[4] == 5);
            Assert.IsTrue(preOrderTraversalList[5] == 3);
            Assert.IsTrue(preOrderTraversalList[6] == 6);
            Assert.IsTrue(preOrderTraversalList[7] == 7);

            listBinaryTree.Clear();

            listBinaryTree.Add(1);

            preOrderTraversalList = listBinaryTree.PreOrderTraversal();

            Assert.IsTrue(preOrderTraversalList.Count == 1);
            Assert.IsTrue(preOrderTraversalList[0] == 1);

            listBinaryTree.Clear();

            preOrderTraversalList = listBinaryTree.PreOrderTraversal();

            Assert.IsTrue(preOrderTraversalList.Count == 0);
        }

        [TestMethod()]
        public void ReversePreOrderTraversalTest()
        {
            var listBinaryTree = new ListCompleteBinaryTree<int>();

            listBinaryTree.Add(1);
            listBinaryTree.Add(2);
            listBinaryTree.Add(3);
            listBinaryTree.Add(4);
            listBinaryTree.Add(5);
            listBinaryTree.Add(6);
            listBinaryTree.Add(7);
            listBinaryTree.Add(8);

            //1
            //2,    3
            //4, 5, 6, 7
            //8

            var reversePreOrderTraversalList = listBinaryTree.ReversePreOrderTraversal();

            Assert.IsTrue(reversePreOrderTraversalList.Count == 8);
            Assert.IsTrue(reversePreOrderTraversalList[0] == 1);
            Assert.IsTrue(reversePreOrderTraversalList[1] == 3);
            Assert.IsTrue(reversePreOrderTraversalList[2] == 7);
            Assert.IsTrue(reversePreOrderTraversalList[3] == 6);
            Assert.IsTrue(reversePreOrderTraversalList[4] == 2);
            Assert.IsTrue(reversePreOrderTraversalList[5] == 5);
            Assert.IsTrue(reversePreOrderTraversalList[6] == 4);
            Assert.IsTrue(reversePreOrderTraversalList[7] == 8);

            listBinaryTree.Clear();

            listBinaryTree.Add(1);

            reversePreOrderTraversalList = listBinaryTree.ReversePreOrderTraversal();

            Assert.IsTrue(reversePreOrderTraversalList.Count == 1);
            Assert.IsTrue(reversePreOrderTraversalList[0] == 1);

            listBinaryTree.Clear();

            reversePreOrderTraversalList = listBinaryTree.ReversePreOrderTraversal();

            Assert.IsTrue(reversePreOrderTraversalList.Count == 0);
        }
    }
}