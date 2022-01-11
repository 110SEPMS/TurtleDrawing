using System;
using System.Collections.Generic;
using TurtleDrawing.DataStructures.Exceptions;

namespace TurtleDrawing.DataStructures
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        /// <summary>
        /// 當前節點資料。
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// 左子樹。
        /// </summary>
        public BinaryTree<T> Left { get; set; }
        /// <summary>
        /// 右子樹。
        /// </summary>
        public BinaryTree<T> Right { get; set; }
        /// <summary>
        /// 取得中序走訪的元素列表。
        /// </summary>
        public List<T> InOrderList
        {
            get
            {
                var list = new List<T>();
                InOrder(ref list);
                return list;
            }
        }
        /// <summary>
        /// 取得前序走訪的元素列表。
        /// </summary>
        public List<T> PreOrderList
        {
            get
            {
                List<T> list = new List<T>();
                PreOrder(ref list);
                return list;
            }
        }
        /// <summary>
        /// 取得後序走訪的元素列表。
        /// </summary>
        public List<T> PostOrderList
        {
            get
            {
                List <T> list = new List<T>();
                PostOrder(ref list);
                return list;
            }
        }

        public BinaryTree(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public BinaryTree(T[] array)
        {
            foreach (T value in array)
            {
                Insert(value);
            }
        }

        public BinaryTree(List<T> list)
        {

        }

        /// <summary>
        /// 插入一筆資料。
        /// </summary>
        /// <param name="value">欲插入的資料。</param>
        public void Insert(T value)
        {
            if (Value.CompareTo(value) < 0)
            {
                if (Right == null)
                {
                    Right = new BinaryTree<T>(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
            else if (Value.CompareTo(value) > 0)
            {
                if (Left == null)
                {
                    Left = new BinaryTree<T>(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
        }
        /// <summary>
        /// 插入一棵樹。
        /// </summary>
        /// <param name="binaryTree">欲插入的樹。</param>
        public void Insert(BinaryTree<T> binaryTree)
        {

        }
        /// <summary>
        /// 移除一筆資料。
        /// </summary>
        /// <param name="value">欲移除的資料。</param>
        public void Remove(T value)
        {

        }

        /// <summary>
        /// 中序走訪，並儲存序列。
        /// </summary>
        /// <param name="list">欲儲存之序列。</param>
        private void InOrder(ref List<T> list)
        {
            if (!(Left == null))
            {
                Left.InOrder(ref list);
            }

            list.Add(Value);

            if (!(Right == null))
            {
                Right.InOrder(ref list);
            }
        }

        /// <summary>
        /// 前序走訪，並儲存序列。
        /// </summary>
        /// <param name="list">欲儲存之序列。</param>
        private void PreOrder(ref List<T> list)
        {
            list.Add(Value);

            if (!(Left == null))
            {
                Left.InOrder(ref list);
            }

            if (!(Right == null))
            {
                Right.InOrder(ref list);
            }
        }

        /// <summary>
        /// 後序走訪，並儲存序列。
        /// </summary>
        /// <param name="list">欲儲存之序列。</param>
        private void PostOrder(ref List<T> list)
        {

        }

        /// <summary>
        /// 檢查value是否存在於此BinaryTree。
        /// </summary>
        /// <param name="value">欲尋找之值。</param>
        /// <returns>若value存在傳回true，否則傳回false。</returns>
        public bool Exists(T value)
        {
            if (Value.Equals(value))
            {
                return true;
            }
            else
            {
                return 
                    (!(Left == null) && Left.Exists(value)) ||
                    (!(Right == null) && Right.Exists(value));
            }
        }

    }
}
