namespace CodeWarsTest
{
    public class WeirdStringCase
    {
        public static string ToWeirdCase(string s)
        {
            string[] array = s.Split(' ');
            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        result += array[i][j].ToString().ToUpper();
                    }
                    else
                    {
                        result += array[i][j].ToString().ToLower();
                    }
                }

                result += " ";
            }

            return result.TrimEnd();
        }
    }
}
