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

            //string result = StockList.stockSummary(new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" }, new string[] { "A", "B" });
            //string result2 = StockList.stockSummary(new string[] { "ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60" }, new string[] { "A", "B", "C", "W" });

            //Console.WriteLine(result);
            //Console.WriteLine(result2);

            //string battleResult = GoodVsEvilBattle.GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1");
            //string battleResult2 = GoodVsEvilBattle.GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0");
            //string battleResult3 = GoodVsEvilBattle.GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0");
            //string battleResult4 = GoodVsEvilBattle.GoodVsEvil("1 0 0 0 1 0", "0 0 0 0 0 1 0");
            //string battleResult5 = GoodVsEvilBattle.GoodVsEvil("0 1 0 0 0 0", "1 0 0 0 0 0 0");

            //Console.WriteLine(battleResult);
            //Console.WriteLine(battleResult2);
            //Console.WriteLine(battleResult3);
            //Console.WriteLine(battleResult4);
            //Console.WriteLine(battleResult5);

            //string weirdStringResult = WeirdStringCase.ToWeirdCase("String");
            //string weirdStringResult2 = WeirdStringCase.ToWeirdCase("Weird string case");
            //string weirdStringResult3 = WeirdStringCase.ToWeirdCase("This is a test");

            //Console.WriteLine(weirdStringResult);
            //Console.WriteLine(weirdStringResult2);
            //Console.WriteLine(weirdStringResult3);

            //string firstLetter = FirstNonRepeatingCharacter.FirstNonRepeatingLetter("a");
            //string firstLetter2 = FirstNonRepeatingCharacter.FirstNonRepeatingLetter("stress");
            //string firstLetter3 = FirstNonRepeatingCharacter.FirstNonRepeatingLetter("moonmen");
            //string firstLetter4 = FirstNonRepeatingCharacter.FirstNonRepeatingLetter("sTreSS");
            //string firstLetter5 = FirstNonRepeatingCharacter.FirstNonRepeatingLetter("checkText");

            //Console.WriteLine(firstLetter);
            //Console.WriteLine(firstLetter2);
            //Console.WriteLine(firstLetter3);
            //Console.WriteLine(firstLetter4);
            //Console.WriteLine(firstLetter5);


            var collection = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };
            var helper = new PaginationHelper<char>(collection, 4);

            Console.WriteLine($"Total Items: {helper.ItemCount}"); // Output: 6
            Console.WriteLine($"Total Pages: {helper.PageCount}"); // Output: 2

            // Page 0 has: 'a', 'b', 'c', 'd' (4 items)
            Console.WriteLine($"Items on Page 0: {helper.PageItemCount(0)}"); // Output: 4

            // Page 1 has: 'e', 'f' (2 items)
            Console.WriteLine($"Items on Page 1: {helper.PageItemCount(1)}"); // Output: 2

            // Page 2 doesn't exist
            Console.WriteLine($"Items on Page 2: {helper.PageItemCount(2)}"); // Output: -1

            // Find which page item index 5 ('f') is on
            Console.WriteLine($"Page of item index 5: {helper.PageIndex(5)}"); // Output: 1

            // Find which page item index 2 ('c') is on
            Console.WriteLine($"Page of item index 2: {helper.PageIndex(2)}"); // Output: 0

            // Index 20 doesn't exist
            Console.WriteLine($"Page of item index 20: {helper.PageIndex(20)}"); // Output: -1

            Console.ReadKey();
        }
    }
}
