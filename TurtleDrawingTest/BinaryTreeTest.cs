using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TurtleDrawing.DataStructures;

namespace TurtleDrawingTest
{
    [TestClass]
    public class BinaryTreeTest
    {

        [TestMethod]
        public void InOrder()
        {
            // Arrange
            BinaryTree<int> binaryTree = new BinaryTree<int>(0);
            binaryTree.Insert(5);
            binaryTree.Insert(-3);
            binaryTree.Insert(7);

            // Act
            List<int> list = binaryTree.InOrderList;

            // Assert
            CollectionAssert.AreEqual(new List<int> {-3, 0, 5, 7}, list);
        }

        [TestMethod]
        public void Exists_OnlyRootNode()
        {
            // Arrange
            BinaryTree<int> binaryTree = new BinaryTree<int>(0);

            // Assert
            Assert.IsTrue(binaryTree.Exists(0));
            Assert.IsFalse(binaryTree.Exists(1));
        }

        [TestMethod]
        public void Exists()
        {
            // Arrange
            BinaryTree<int> binaryTree = new BinaryTree<int>(10);
            binaryTree.Insert(5);
            binaryTree.Insert(-3);
            binaryTree.Insert(7);

            // Assert
            Assert.IsTrue(binaryTree.Exists(10));
            Assert.IsTrue(binaryTree.Exists(5));
            Assert.IsTrue(binaryTree.Exists(-3));
            Assert.IsTrue(binaryTree.Exists(7));

            Assert.IsFalse(binaryTree.Exists(3));
            Assert.IsFalse(binaryTree.Exists(1));
        }
    }
}
