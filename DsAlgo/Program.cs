 using System;

namespace DsAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            var r= TwoSum(nums, 9);
        }

        /// <summary>
        /// https://leetcode.com/problems/two-sum/submissions/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {

            int cNum = 0;
            int[] outt = new int[2] { -1,-1};
            while (cNum != nums.Length )
            {
                for (int i = cNum; i < nums.Length; i++)
                {
                    if (nums[i] + nums[cNum] == target && i!=cNum)
                    {
                        outt[0] = i;
                        outt[1] = cNum;
                    }
                }
                cNum++;
            }
            return outt;
        }
    }
}
