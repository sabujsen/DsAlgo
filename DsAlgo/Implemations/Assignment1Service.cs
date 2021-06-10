using DsAlgo.Interfaces;
using System.Linq;

namespace DsAlgo.Implemations
{
    public class Assignment1Service : IAssignment1Service
    {
        public int MostWaterArea(int[] height)
        {
            var calculateMostWaterAreaMax = 0;
            if (height.Any())
            {
                var leftHeight = height[0];
                var rightHeight = height[height.Length - 1];
                var index = 0;
                var leftIndex = 0;
                var rightIndex = 0;
                var maxLength = height.Length - 1;

                while (index < height.Length - 1)
                {
                    // calculate min height for area's height
                    var minYHeght = leftHeight < rightHeight ? leftHeight : rightHeight;
                    var calculateMostWaterArea = minYHeght * (maxLength - index);
                    // keep height value
                    calculateMostWaterAreaMax = calculateMostWaterAreaMax == 0 ? calculateMostWaterArea : calculateMostWaterAreaMax > calculateMostWaterArea ? calculateMostWaterAreaMax : calculateMostWaterArea;

                    // chack which min left of right and increase accodingly
                    if (leftHeight <= rightHeight)
                    {
                        leftIndex++;
                        leftHeight = height[leftIndex];
                    }
                    else
                    {
                        rightIndex++;
                        rightHeight = height[(height.Length - 1) - rightIndex];
                    }

                    index++;
                }
            }
            return calculateMostWaterAreaMax;
        }
    
    }
}
