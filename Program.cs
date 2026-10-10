var result = new Solution().GetConcatenation([1, 2, 1]);
Console.WriteLine(string.Join(", ", result)); // verwacht: 1, 2, 1, 1, 2, 1

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] ans = new int[nums.Length * 2];

        int i = 0, j = 0;

        while (i < ans.Length)
        {
            if (i == nums.Length)
                j = 0;

            ans[i] = nums[j];
            i++; j++;
        }

        return ans;
    }
}
