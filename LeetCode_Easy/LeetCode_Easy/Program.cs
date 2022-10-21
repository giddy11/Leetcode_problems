// See https://aka.ms/new-console-template for more information

int RemoveDuplicates(int[] nums)
{
    int j = 0;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        //var arr = new List<int>();
        if (nums[i] != nums[i + 1])
        {
            nums[j] = nums[i];
            //arr.Add(nums[i]);
            j++;
        }


    }
    nums[j++] = nums[nums.Length - 1];

    return j;
}

var nums = new int[] { 0, 1, 1, 2, 5, 5, 8, 9 };
Console.WriteLine(RemoveDuplicates(nums));