var result = new Solution().GetConcatenation([1, 2, 1]);
Console.WriteLine(string.Join(", ", result)); // verwacht: 1, 2, 1, 1, 2, 1

public class Solution
{
    public int[] GetConcatenation(int[] nums) =>
        [.. nums, .. nums];
}
