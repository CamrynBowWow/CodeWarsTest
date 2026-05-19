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

            //int[] newArray = [];

            //for (int j = 0; j < b.Length; j++)
            //{
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] != b[j])
            //        {
            //            newArray = newArray.Append(a[i]).ToArray();
            //        }
            //    }
            //}

            //return newArray;
        }
    }
}
