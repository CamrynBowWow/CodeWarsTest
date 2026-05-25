using System.Text;

namespace CodeWarsTest
{
    public class StockList
    {
        public static string stockSummary(string[] lstOfArt, string[] lstOf1stLetter)
        {
            Dictionary<string, int> bookList = new Dictionary<string, int>();

            for (int i = 0; i < lstOf1stLetter.Length; i++)
            {
                for (int j = 0; j < lstOfArt.Length; j++)
                {
                    if (bookList.ContainsKey(lstOf1stLetter[i]))
                    {
                        if (bookList.TryGetValue(lstOfArt[j].Substring(0, 1), out int value) && lstOfArt[j].Substring(0, 1) == lstOf1stLetter[i])
                        {
                            bookList[lstOfArt[j].Substring(0, 1)] = value + Convert.ToInt32(lstOfArt[j].Split(' ')[1]);
                        }
                    }
                    else if (lstOfArt[j].Substring(0, 1) == lstOf1stLetter[i])
                    {
                        bookList.Add(lstOfArt[j].Substring(0, 1), Convert.ToInt32(lstOfArt[j].Split(' ')[1]));
                    }
                    else if (!bookList.ContainsKey(lstOf1stLetter[i]))
                    {
                        bookList.Add(lstOf1stLetter[i], 0);
                    }
                }
            }

            var stringBuilder = new StringBuilder();

            string result = string.Join($" - ", bookList.Select(kvp => $"({kvp.Key} : {kvp.Value})"));
            
            return stringBuilder.Append(result).ToString();
        }
    }
}
