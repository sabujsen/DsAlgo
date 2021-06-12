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

    public class CircularQueue<T>
    {
        int front, rear = -1;
        int capacity = 0;
        private T[] queue ;

        public CircularQueue(int _capacity)
        {
            this.capacity = _capacity;
            queue = new T[_capacity];
            front= rear = -1;
        }

        public void EnQueue(T element)
        {
            // check queue is full
            if ((front == 0 && rear == capacity - 1) || (rear == (front - 1) % (capacity - 1)))
            {
                Console.WriteLine("Queue is Full");
                throw new Exception("Queue is full");
            }

            if ((front == -1) && (rear == -1))
            {
                front = 0;
                rear = 0;
                queue[0] = element;
            }
            else
            {
                var positiontoAdd =  (rear + 1) % capacity;
                front = 0;
                rear = (rear+1) ;
                queue[positiontoAdd] = element;
            }            
        }
        public T DeQueue()
        {
            T temp;
            if (IsEmpty())
            {
                throw new NullReferenceException("List is empty");
            }
            temp = queue[front];
            // Condition for only one element
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else
            {
                var positiontoRemove = (front + 1) % capacity;
                front = positiontoRemove;
            }
            return temp;
        }
        public T Peek()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                // throw new Exception("Queue is empty");
            }
            return queue[front];
        }
        public bool IsEmpty()
        {
            //if ((front == 0 && rear == capacity - 1) || (rear == (front - 1) % (capacity - 1)))
            //{
            //    return false;
            //}
            return front==-1;
        }
        public bool IsFull()
        {           
            return rear++%capacity==front;
        }
        public void DisplayQueue()
        {

            // Condition for empty queue.
            if (front == -1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            // If rear has not crossed the max size
            // or queue rear is still greater then
            // front.
            Console.WriteLine("Elements in the circular queue are: ");

            if (rear >= front)
            {

                // Loop to print elements from
                // front to rear.
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(queue[i]);
                    Console.WriteLine(" ");
                }
                Console.WriteLine();
            }

            // If rear crossed the max index and
            // indexing has started in loop
            else
            {

                // Loop for printing elements from
                // front to max size or last index
                for (int i = front; i < capacity; i++)
                {
                    Console.WriteLine(queue[i]);
                    Console.WriteLine(" ");
                }

                // Loop for printing elements from
                // 0th index till rear position
                for (int i = 0; i <= rear; i++)
                {
                    Console.WriteLine(queue[i]);
                    Console.WriteLine(" ");
                }
                Console.WriteLine();
            }
        }
        }
}
