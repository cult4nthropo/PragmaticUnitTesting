using System;

namespace TestNumberComparison
{
    internal class Cmp
    {
        public static int Largest(int [] values)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            return max;
        }
    }
}