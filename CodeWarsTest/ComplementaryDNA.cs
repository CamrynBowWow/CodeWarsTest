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
                //if (dnaArray[i] == 'A')
                //{
                //    dnaArray[i] = 'T';
                //}
                //else if (dnaArray[i] == 'T')
                //{
                //    dnaArray[i] = 'A';
                //}
                //else if (dnaArray[i] == 'C')
                //{
                //    dnaArray[i] = 'G';
                //}
                //else if (dnaArray[i] == 'G')
                //{
                //    dnaArray[i] = 'C';
                //}
            }

            return new string(dnaArray);

            //string[] returnValue;

            //foreach(char value in dna)
            //{

            //    value = value == 'A' ? 'T' : value == 'T' ? 'A' : value == 'C' ? 'G' : 'C';
            //}
        }
    }
}
