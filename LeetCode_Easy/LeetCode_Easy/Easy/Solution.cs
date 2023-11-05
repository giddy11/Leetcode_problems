using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Easy.Easy
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count++] = nums[i];
                    //count++;
                }
            }
            return count;
        }

        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                    return i;
            }
            return nums.Length;
        }
    }

    public static class Solution1
    {

        public static int[] PlusOne(int[] digits)
        {
            int len = digits.Length;
            int final = len - 1;

            for (int i = final; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            var numberArr = new int[len + 1];
            numberArr[0] = 1;
            return numberArr;
        }



















        //public static int[] PlusOne(int[] digits)
        //{
        //    int n = digits.Length;
        //    for (int i = n - 1; i >= 0; i--)
        //    {
        //        if (digits[i] < 9)
        //        {
        //            digits[i]++;
        //            return digits;
        //        }
        //        digits[i] = 0;
        //    }
        //    int[] newNumber = new int[n + 1];
        //    newNumber[0] = 1;

        //    return newNumber;
        //}
    }

    public class Solution2
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            if (x < 10)
                return true;

            int digit, rev_x = 0;
            int orig_x = x;

            while(x > 0)
            {
                digit = x % 10;
                rev_x = rev_x * 10 + digit;
                x /= 10;
            }

            if (rev_x == orig_x)
                return true;
            else
                return false;
        }
    }
}
