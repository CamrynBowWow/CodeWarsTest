namespace CodeWarsTest
{
    public class ArrayDifference
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            if (b == null || b.Length == 0)
            {
                return a;
            }

            List<int> first = new List<int>(a);
            List<int> second = new List<int>(b);

            first.RemoveAll(x => second.Contains(x));

            return first.ToArray();
        }
    }
}
