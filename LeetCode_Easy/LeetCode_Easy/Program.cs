// See https://aka.ms/new-console-template for more information

/*
using LeetCode_Easy.Easy;

Solution solution = new Solution();

int[] nums = { 3, 2, 2, 3 };
int[] nums1 = { 1, 2, 5, 6 };

int val = 3;
int target = -2;

int newLength = solution.RemoveElement(nums, val);
int newLength1 = solution.SearchInsert(nums1, target);

Console.WriteLine("Modified Array: ");

//for (int i = 0; i < newLength; i++)
//{
//    Console.WriteLine($"{nums[i]} ");
//}
//Console.WriteLine("\n");

Console.WriteLine($"Number of elements not equal to {val}: {newLength1}\n");
*/

/*
using LeetCode_Easy.Easy;

int[] result1 = Solution1.PlusOne(new int[] { 8,9 });
*/


using LeetCode_Easy.Easy;

var test = new Solution2();
bool x = test.IsPalindrome(-101);



Console.WriteLine(x);


/*
 
 var newList = new List<string> ();
    var count = 0;

    customers.Sort();

    for (int i = 0; customers[i] != null; i++)
    {
        if (customers[i] == customers[i+1] && count < 5)
        {
            count++;
            continue;
        }
        if (count >= 4 && customers[i] == customers[i - 1])
            newList.Add(customers[i]);

        count = 0;
    }
 */