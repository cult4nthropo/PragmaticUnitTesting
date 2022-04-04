using System;
using System.Linq;

namespace TestNumberComparison
{
    internal class Cmp
    {
        public static int Largest(int [] values)
        {
            int max = Int32.MinValue;
            if (values.Length == 0)
            {
                throw new ArgumentException("The array is empty.");
            }
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