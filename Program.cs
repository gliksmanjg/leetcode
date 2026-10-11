
Console.WriteLine(Kata.SpinWords("Hey fellow warriors"));


public class Kata
{
    public static string SpinWords(string sentence) =>
        string.Join(" ", sentence.Split(" ")
                                 .Select(word => word.Length > 4 ? $"{ [.. word.Reverse()]}" : word));
}
