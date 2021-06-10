using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DsAlgo
{
    public class DSAService : IDSAService
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

        /// <summary>
        /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public IList<string> LetterCombinations(int digits)
        {

            // check induvidual digits are >2 <9
            //if (Regex.IsMatch(digits, "^\\d+$"))
            //{

            //}

            // get value of digits each
            for (int i = 0; i <= digits.ToString().Length - 1; i++)
            {
                var r = digits.ToString().Substring(i, 1);
                var t = Enum.GetValues(typeof(LetterCombinationsList)).GetValue(2 - 2).ToString();
                for (i = 0; i <= t.Length - 1; i++)
                {
                    var rr = t.Split("");
                }
            }


            // get combination of  of digits each

            //Combine each
            return null;
        }


        public int Fibbonaci(int i)
        {
            return 1;
        }


    }
}
