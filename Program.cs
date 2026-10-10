
int[] nums = [15, 7, 8, 11, 2];
int target = 9;

/* Reflection

Brute-forced -> time complexity O(n^2) which is bad.

If I first sort the array @ O(n), afterwards I can shorten the array to only include numbers lower than `Target`, and iterate over them to create the sum @ O(n)

*/

static string GetIndices(int[] nums, int target)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] < target)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                sum = nums[i] + nums[j];
                if (sum == target) return $"[{i}, {j}]";
            }
        }
    }

    return "";
}

Console.WriteLine(GetIndices(nums, target));