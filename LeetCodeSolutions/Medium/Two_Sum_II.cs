using System;


public class SolutionTwoSum2
{
    public int[] TwoSum(int[] nums, int target)
    {

        int leftBorder = 0;
        int rightBorder = nums.Length - 1;

        while (leftBorder < rightBorder)
        {
            if (nums[leftBorder] + nums[rightBorder] > target)
            {
                rightBorder--;
            }
            else if (nums[leftBorder] + nums[rightBorder] < target)
            {
                leftBorder++;
            }
            else if (nums[leftBorder] + nums[rightBorder] == target)
            {
                break;
            }
        }

        int[] result = new int[2];
        result[0] = ++leftBorder;
        result[1] = ++rightBorder;
        return result;
    }
}

