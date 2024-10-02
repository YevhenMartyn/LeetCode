using System;


public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] sortedNums = (int[])nums.Clone();
        Array.Sort(sortedNums);
        int leftBorder = 0;
        int rightBorder = nums.Length - 1;

        while (leftBorder < rightBorder)
        {
            if (sortedNums[leftBorder] + sortedNums[rightBorder] > target)
            {
                rightBorder--;
            }
            else if (sortedNums[leftBorder] + sortedNums[rightBorder] < target)
            {
                leftBorder++;
            }
            else if (sortedNums[leftBorder] + sortedNums[rightBorder] == target)
            {
                break;
            }
        }

        int[] result = new int[2];
        if (sortedNums[leftBorder] == sortedNums[rightBorder])
        {
            result[0] = Array.IndexOf(nums, sortedNums[leftBorder]);
            result[1] = Array.LastIndexOf(nums, sortedNums[rightBorder]);
        }
        else
        {
            result[0] = Array.IndexOf(nums, sortedNums[leftBorder]);
            result[1] = Array.IndexOf(nums, sortedNums[rightBorder]);
        }

        Array.Sort(result);
        return result;
    }
}

