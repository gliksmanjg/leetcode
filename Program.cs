/* Reflection

BubbleSort heeft een tijdscomplexiteit van O(n^2) vanwege de recursie:

    1. De loop intereert eerst over nums.Length elementen -> lineair O(n) -> result [7, 11, 2, 15]
    2. Recursie wordt aangeroepen en verwijderd de laatste index:
        - aantal operaties: n + (n - 1) + (n - 2) + ... + 1 -> n = nums.Length => 4 + 3 + 2 + 1 = 10
    3. De loop onderaan is O(n)
    
    ==> big-o notatie: #1 is een loop = O(n), #3 is een loop O(n), #2 recursie is een loop-wrapper rond de #1 loop => O(n) * O(n) = O(n^2)

*/

int[] nums = [15, 7, 11, 2];
int target = 9;

static void BubbleSort(int[] nums, int length)
{
    // base case
    if (length <= 1) return;

    int temp;
    for (int i = 0; i < length - 1; i++)
    {
        ref int current = ref nums[i]; // zonder `ref` krijg ik een kopie
        ref int next = ref nums[i + 1];

        if (current > next)
        {
            temp = current;
            current = next;
            next = temp;
        }
    }

    BubbleSort(nums, length - 1);
}

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