foreach (var item in ArrayDiff([1, 2, 2, 3], [2]))
{
    Console.WriteLine(item);
}

static int[] ArrayDiff(int[] a, int[] b)
{
    HashSet<int> ints = [.. b];
    return [.. a.Where(n => !ints.Contains(n))];
}