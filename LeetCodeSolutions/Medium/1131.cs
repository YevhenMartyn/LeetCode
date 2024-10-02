/*
Given two arrays of integers with equal lengths, return the maximum value of:

|arr1[i] - arr1[j]| + |arr2[i] - arr2[j]| + |i - j|

where the maximum is taken over all 0 <= i, j < arr1.length.

 
*/


public class Solution1131
{
    public int MaxAbsValExpr(int[] arr1, int[] arr2)
    {
        int arrLength = arr1.Length;
        int[] sumArray = new int[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
            sumArray[i] = Math.Abs(arr1[i]) + Math.Abs(arr2[i]) + i;
        }

        Array.Sort(sumArray);
        int result = sumArray[-1] - sumArray[0];
        return result;
    }
}