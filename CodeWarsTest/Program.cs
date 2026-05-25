using CodeWarsTasks;

namespace CodeWarsTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string results = HighAndLow.HighAndLowTest("1 2 3 4 5");
            //string results2 = HighAndLow.HighAndLowTest("1 2 -3 4 5");
            //string results3 = HighAndLow.HighAndLowTest("1 9 3 4 -5");

            //Console.WriteLine(results);
            //Console.WriteLine(results2);
            //Console.WriteLine(results3);

            //string dnaResults = ComplementaryDNA.MakeComplement("AAAA");
            //string dnaResults2 = ComplementaryDNA.MakeComplement("ATTGC");
            //string dnaResults3 = ComplementaryDNA.MakeComplement("CGCG");
            //string dnaResults4 = ComplementaryDNA.MakeComplement("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA");

            //Console.WriteLine(dnaResults);
            //Console.WriteLine(dnaResults2);
            //Console.WriteLine(dnaResults3);
            //Console.WriteLine(dnaResults4);

            //string result = ConvertToCamelCase.ToCamelCase("the-stealth-warrior");
            //string result2 = ConvertToCamelCase.ToCamelCase("The_Stealth_Warrior");
            //string result3 = ConvertToCamelCase.ToCamelCase("The_Stealth-Warrior");

            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);

            //int[] result = ArrayDifference.ArrayDiff(new[] { 1, 2, 2 }, new[] { 1 });
            //int[] result2 = ArrayDifference.ArrayDiff(new[] { 1, 2, 2 }, new int[] { });
            //int[] result3 = ArrayDifference.ArrayDiff(new[] { 1, 2, 3 }, new[] { 1, 2 });

            //Console.WriteLine(string.Join(", ", result));
            //Console.WriteLine(string.Join(", ", result2));
            //Console.WriteLine(string.Join(", ", result3));

            string result = StockList.stockSummary(new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" }, new string[] { "A", "B" });
            string result2 = StockList.stockSummary(new string[] { "ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60" }, new string[] { "A", "B", "C", "W" });

            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}
