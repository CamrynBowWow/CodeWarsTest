class HighAndLow
{
    static void Main(string[] args)
    {
        string results = HighAndLowTest("1 2 3 4 5");
        string results2 = HighAndLowTest("1 2 -3 4 5");
        string results3 = HighAndLowTest("1 9 3 4 -5");

        Console.WriteLine(results);
        Console.WriteLine(results2);
        Console.WriteLine(results3);

        Console.ReadKey();
    }

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





