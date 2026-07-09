namespace CodeWarsTest
{
    public class FirstNonRepeatingCharacter
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            string letter = "";

            char[] letterArray = s.ToCharArray();
            List<char> failedLetters = new List<char>();


            for (int i = 0; i < letterArray.Length; i++)
            {
                char tempLetter = letterArray[i];
                char lowerTemp = char.ToLower(tempLetter);

                int matchCount = letterArray.Count(c => char.ToLower(c) == lowerTemp);

                if (matchCount > 1)
                {
                    if (!failedLetters.Contains(lowerTemp))
                    {
                        failedLetters.Add(lowerTemp);
                    }
                }
            }

            foreach (char c in letterArray)
            {
                if (!failedLetters.Contains(char.ToLower(c)))
                {
                    return c.ToString();
                }
            }

            return "";
        }
    }
}
