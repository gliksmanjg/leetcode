using System.Collections.ObjectModel;

foreach (var item in MoveZeroes2([1, 2, 0, 1, 0, 1, 0, 3, 0, 1]))
{
    Console.WriteLine(item);
}

static int[] MoveZeroes(int[] arr)
{
    int[] result = new int[arr.Length];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            result[j++] = arr[i];
    }

    return result;
}



/*  Hoe werkt OrderBy?:

    Deze extension method vergelijkt elk getal met de expressie.
    Als een getal niet overeenkomt is het FALSE, anders TRUE.
    Standaard is de waarde FALSE.

    Alle waarden die FALSE zijn, blijven vooraan in de lijst.
    Alle waarden die TRUE zijn, worden achteraan gesorteerd.

    Bij OrderByDescending worden alle TRUE-waarden vooraan
    geplaatst en FALSE achteraan.

*/

static int[] MoveZeroes2(int[] arr) =>
    [.. arr.OrderBy(n => n == 0)];