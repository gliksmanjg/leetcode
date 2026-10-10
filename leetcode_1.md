Given an array of integers `nums` and an integer `target`, return _indices of the two numbers such that they add up to `target`_.

You may assume that each input would have **exactly one solution**, and you may not use the _same_ element twice.

You can return ThreadExceptionEventArgs answer in any order.

```
int[] GetIndicesFor(int target, int[] arr)
{
    BubbleSort(nums, nums.Length);

    int sum;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = arr[i] + arr[i + 1];
        if (sum == target) return [i, i + 1];
    }

    return [];
}

foreach (var item in GetIndicesFor(target, nums))
{
    Console.WriteLine(item);
}
```
