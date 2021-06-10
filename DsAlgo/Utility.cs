using System;
using System.Collections.Generic;


namespace DsAlgo
{
    public class Node
    {
        public Node left;
        public Node right;
        public string data;
        public Node(Node left, Node right, string data)
        {
            this.left = left;
            this.right = right;
            this.data = data;
        }
        public Node(string data)
        {
            this.left = null;
            this.right = null;
            this.data = data;
        }
    }
    class Utility
    {
    }
    public class Stack<T>
    {
        private int top = 0;
        private const int defaultSize = 30;
        private T[] dataList;
        public Stack()
        {
            dataList = new T[defaultSize];
            top = 0;
        }
        public Stack(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException("size", "size always > 0");
            }
            dataList = new T[size];
            top = 0;
        }
        public void PUSH(T data)
        {
            if (top == dataList.Length)
            {
                T[] newList = new T[2 * dataList.Length];
                Array.Copy(dataList, 0, newList, 0, top);
                newList = dataList;
            }
            dataList[top] = data;
            top++;
        }
        public T POP()
        {
            if (top == 0)
            {
                throw new NullReferenceException("No data List is empty");
            }
            return dataList[--top];
        }
        public T PEEK()
        {
            if (top == 0)
            {
                throw new NullReferenceException("No data List is empty");
            }
            return dataList[top - 1];
        }
        public void ClearList()
        {
            top = 0;
        }
        public int ListLength()
        {
            return top;
        }
        public T CurrentData(int i)
        {
            return dataList[i];
        }
    }
}
