using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo
{
   public class DSAService: IDSAService
    {
        /// <summary>
        /// https://leetcode.com/problems/two-sum/submissions/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {

            int cNum = 0;
            int[] outt = new int[2] { -1, -1 };
            while (cNum != nums.Length)
            {
                for (int i = cNum; i < nums.Length; i++)
                {
                    if (nums[i] + nums[cNum] == target && i != cNum)
                    {
                        outt[0] = i;
                        outt[1] = cNum;
                    }
                }
                cNum++;
            }
            return outt;
        }

        /// <summary>
        /// Reverse the Stack
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public Stack<int> ReverseStack(Stack<int> list)
        {         
            if (list.ListLength() > 0)
            {

                // clear the stauck
                var x = (int)list.PEEK();
                list.POP();
                ReverseStack(list);

                //put every item bootom of the stuck
                InsertAtBottom(x, list);
            }
            return list;
        }
        static Stack<int> InsertAtBottom(int x, Stack<int> list)
        {

            if (list.ListLength() == 0)
            {
                list.PUSH(x);
            }
            else
            {

                // until stack becomes empty, above if part is executed and the item is inserted at the bottom 
                var a = (int)list.PEEK();
                list.POP();
                InsertAtBottom(x, list);

                // push all the items func Call Stack once the item is inserted at the bottom 
                list.PUSH(a);
            }
            return list;
        }

        public int Fibbonaci(int i)
        {
            return 1;
        }
    }
}
