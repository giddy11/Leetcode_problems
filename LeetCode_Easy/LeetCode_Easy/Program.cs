// See https://aka.ms/new-console-template for more information

int RemoveDuplicates(int[] nums)
{
    //int leftPointer = 1;

    //for (int rightPointer = 1; rightPointer < nums.Length; rightPointer++)
    //{
    //    if (nums[rightPointer] != nums[rightPointer - 1])
    //    {
    //        nums[leftPointer++] = nums[rightPointer];
    //        //leftPointer++;

    //    }

    //}
    //return leftPointer;

    int rightPointer = 1;

    for (int leftPointer = 0; leftPointer < nums.Length - 1; leftPointer++)
    {
        if (nums[leftPointer] != nums[leftPointer + 1])
        {
            nums[rightPointer++] = nums[leftPointer + 1];
        }
    }
    return rightPointer;
}

var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
Console.WriteLine(RemoveDuplicates(nums));