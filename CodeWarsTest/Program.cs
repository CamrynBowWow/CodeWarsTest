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

            string dnaResults = ComplementaryDNA.MakeComplement("AAAA");
            string dnaResults2 = ComplementaryDNA.MakeComplement("ATTGC");
            string dnaResults3 = ComplementaryDNA.MakeComplement("CGCG");
            string dnaResults4 = ComplementaryDNA.MakeComplement("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA");

            Console.WriteLine(dnaResults);
            Console.WriteLine(dnaResults2);
            Console.WriteLine(dnaResults3);
            Console.WriteLine(dnaResults4);

            Console.ReadKey();
        }
    }
}
