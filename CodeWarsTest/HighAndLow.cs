namespace CodeWarsTasks
{
    public class HighAndLow
    {
        public static string HighAndLowTest(string numbers)
        {
            string[] array = numbers.Split(' ');

            decimal high = Convert.ToDecimal(array[0]);
            decimal low = Convert.ToDecimal(array[0]);
            decimal temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                temp = Convert.ToDecimal(array[i]);

                high = temp > high ? temp : high;

                low = temp < low ? temp : low;
            }

            return Convert.ToString(high + " " + low);
        }
    }
}