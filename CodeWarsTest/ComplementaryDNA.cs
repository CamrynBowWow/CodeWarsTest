namespace CodeWarsTest
{
    public class ComplementaryDNA
    {
        public static string MakeComplement(string dna)
        {
            char[] dnaArray = dna.ToCharArray();

            for(int i = 0; i < dnaArray.Length; i++)
            {
                dnaArray[i] = dnaArray[i] == 'A' ? 'T' : dnaArray[i] == 'T' ? 'A' : dnaArray[i] == 'C' ? 'G' : 'C';
            }

            return new string(dnaArray);
        }
    }
}
