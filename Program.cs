int[] nums = [15, 7, 11, 2];
int target = 9;

// het opdelen van de array
void MergeSort(int[] arr)
{
    if (arr.Length <= 1) return;

    int midIdx = arr.Length / 2;
    int[] left = arr[..midIdx];
    int[] right = arr[midIdx..];

    MergeSort(left);
    MergeSort(right);

    Merge(arr, left, right);
}

// twee gesorteerde helften samenvoegen in arr
void Merge(int[] arr, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;

    while (i < left.Length && j < right.Length)
    {
        arr[k++] = left[i] <= right[j] ? left[i++] : right[j++];
    }

    CopyRemaining(arr, left, i, k);
    CopyRemaining(arr, right, j, k + (left.Length - i));
}

// de overgebleven elementen van één helft kopiëren
void CopyRemaining(int[] arr, int[] source, int sourceIdx, int arrIdx)
{
    while (sourceIdx < source.Length)
    {
        arr[arrIdx++] = source[sourceIdx++];
    }
}

MergeSort(nums);
Console.WriteLine(string.Join(", ", nums)); // 2, 7, 11, 15
