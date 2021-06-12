using DsAlgo.Implemations;
using DsAlgo.Interfaces;
using System;
using System.Collections.Generic;

namespace DsAlgo
{
    class Program
    {

        static IAssignment1Service assignment1Service = new Assignment1Service();
        static IDSAService dsaservice = new DSAService();
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            // int[] arr = new int[] { 1, 2, 3, 4, 5, 25, 24, 3, 4 };
            //  var response = assignment1Service.MostWaterArea(arr);

            List<string> v = new List<string>();

            //v.Add("tom");
            //v.Add("jerry");
            //v.Add("jerry");
            //v.Add("tom");

            v.Add("ab");
            v.Add("aa");
            v.Add("aa");
            v.Add("bcd");
            v.Add("ab");

            //var response = assignment1Service.RemoveConsecutiveSame(v);
            //Console.WriteLine("Response : {0}", response);

            var circularQueue = new CircularQueue<int>(5);

            circularQueue.EnQueue(14);
            circularQueue.EnQueue(22);
            circularQueue.EnQueue(13);
            circularQueue.EnQueue(-6);

          
            circularQueue.EnQueue(9);
            circularQueue.DisplayQueue();

            int x = circularQueue.DeQueue();
            x = circularQueue.DeQueue();

            circularQueue.DisplayQueue();
            //var rr = dsaservice.LetterCombinations(23);


            //var r = dsaservice.Fibbonaci(4);
            //int[] nums = { 2, 7, 11, 15 };
            //var response = dsaservice.TwoSum(nums, 9);
            //Console.WriteLine("two-sum");
            //Console.WriteLine(string.Join(",", response));
            //Console.ReadKey();

            //var myStack = new Stack<int>();
            //myStack.PUSH(1);
            ////myStack.PUSH(3);
            //myStack.PUSH(4);
            //myStack.PUSH(7);
            //PrintStack(myStack);
            //// Console.WriteLine("Item popped from Stack : {0}", myStack.POP());
            ////PrintStack(myStack);

            //Console.WriteLine("After Reverse");
            //var reverseStack = dsaservice.ReverseStack(myStack);
            //PrintStack(reverseStack);

            //Recursion
            //PrintNumbers(1);
            //Console.ReadKey();

        }
        public static void PrintNumbers(int n)
        {
            if (n < 10)
            {
                Console.WriteLine("Head Print : " + n);
                PrintNumbers(n + 1);
                Console.WriteLine("Trail Print : " + n);
            }
            return;

        }
        public static void PrintStack(Stack<int> stack)
        {

            if (stack.ListLength() == 0)
            {
                throw new NullReferenceException("No data List is empty");
            }
            Console.WriteLine("Items in the Stack are :");
            for (int i = stack.ListLength() - 1; i >= 0; i--)
            {
                Console.WriteLine(stack.CurrentData(i));
            }
            Console.ReadKey();
        }

    }
}
