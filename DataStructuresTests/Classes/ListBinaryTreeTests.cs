using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheoSoft.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheoSoft.DataStructures.Tests
{
    [TestClass()]
    public class ListBinaryTreeTests
    {
        [TestMethod()]
        public void InOrderTraversalTest()
        {
            var listBinaryTree = new ListBinaryTree<int>();

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
        public void BreadthFirstTraversalTest()
        {
            var listBinaryTree = new ListBinaryTree<int>();

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
    }
}