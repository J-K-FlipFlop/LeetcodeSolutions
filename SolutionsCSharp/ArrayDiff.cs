namespace CodeWarsSolutions
{
    internal class ContainsDuplicate
    {
        public static int[] ArrayDiffMethod2(int[] a, int[] b)
        {
            List<int> lstA = a.ToList<int>();
            List<int> lstB = b.ToList<int>();
            lstB = lstB.Distinct().ToList();

            for (int i = 0; i < lstB.Count; i++)
            {
                if (lstA.Contains(lstB[i]))
                {
                    lstA.RemoveAll(item => item == lstB[i]);
                }
            }

            int[] result = lstA.ToArray();

            return result;
        }
    }
}