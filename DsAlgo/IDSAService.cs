using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo
{
    public interface IDSAService
    {
        int[] TwoSum(int[] nums, int target);

        Stack<int> ReverseStack(Stack<int> list);

        //Recursion

        int Fibbonaci(int i);
            
    }
}
