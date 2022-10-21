// See https://aka.ms/new-console-template for more information


 int[] TwoSum(int[] nums, int target)
{
    var dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int diff = target - nums[i];
        if (dict.ContainsKey(diff))
        {
            return new int[] {dict[diff], i};
        }
        if (!dict.ContainsKey(nums[i]))
        {
            dict.Add(nums[i], i);
        }
    }
    return null;
}


int[] nums = new int[] {3,6,4,5,3,4,5,6,7,5,4,4,4,4,4,3,3,2,2,1};
int target = 11;
var result = TwoSum(nums, target);

Console.Write($"[{result[0]}, {result[1]}]");


Console.ReadLine();

