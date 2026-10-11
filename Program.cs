Console.WriteLine(find_it2([1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1]));

static int find_it(int[] seq) =>
    seq.GroupBy(n => n)
       .Single(g => g.Count() % 2 != 0)
       .Key;



static int find_it2(int[] seq) =>
    seq.Aggregate((a, b) => a ^ b);

/* bitwise XOR (exclusive OR): werkt als een vlag 'aan of uit'

Als 1 tweemaal voorkomt, annuleert de tweede 1 de eerste (eerst AAN, daarna UIT).

Daarom kan je met XOR even en oneven gemakkelijk uitrekenen. Een oneven aantal zal altijd AAN blijven of in dit geval overblijven omdat die zichzelf niet heeft geannuleerd.

XOR regel:
- 1 en 0 || 0 en 1 = 1
- 1 en 1 || 0 en 0 = 0

1. Je vergelijkt met de eerste 2 getallen uit de array
2. De uitkomst vergelijk je met het volgende getal uit de array
3. item #2

*/


/* bvb [1, 2, 2] -> antwoord: 1

1 = 0001
2 = 0010

01   11
10   10
--   --
11   01 = 1

*/