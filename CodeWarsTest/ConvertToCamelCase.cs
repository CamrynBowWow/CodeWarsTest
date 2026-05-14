namespace CodeWarsTest
{
    public class ConvertToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            string[] wordArray = str.Split(['-', '_']);
            string finalResult = "";

            for(int i = 0; i < wordArray.Length; i++)
            {
                if(i == 0)
                {
                    finalResult += wordArray[i];
                } 
                else
                {
                    finalResult += string.Concat(wordArray[i][0].ToString().ToUpper(), wordArray[i].AsSpan(1));
                }
            }

            return finalResult;
        }
    }
}
