Console.WriteLine(Kata.Rgb(212, 53, 12));
public class Kata
{
    /* This is the best and easiest solution, using :X

        static string Rgb(int r, int g, int b) =>
            $"{r:X}{g:X}{b:X}";

    */

    public static string Rgb(int r, int g, int b) =>
        CalcHex(r) + CalcHex(g) + CalcHex(b);

    private static string CalcHex(int n)
    {
        if (n >= 255) return "FF";
        if (n <= 0) return "00";

        char[] chars = ['A', 'B', 'C', 'D', 'E', 'F'];

        string quotient = n / 16 < 10 ? $"{n / 16}" : $"{chars[n / 16 % 10]}";
        string rest = n % 16 < 10 ? $"{n % 16}" : $"{chars[n % 16 % 10]}";

        return quotient + rest;
    }
}