using System.Globalization;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 12, 45, 23, 51, 18, 8 };
            Sort(ref ints);
            for (int i = 0; i < ints.Length; i++) 
            {
                Console.WriteLine(ints[i]);
            }
            /*
             12, 45, 23, 51, 18, 8

            ---1st iteration---
            i = 1;
            j = i-1 =0;
             12, 45, 23, 51, 18, 8

            --2nd iteration---
            i = 2;
            j = i-1 = 1;
             12, 45, 23, 51, 18, 8
             12, 45, 45, 51, 18, 8
             12, 23, 45, 51, 18, 8

            ---4th iteration---
            i = 4;
            j = 3
            12, 23, 45, 51, 18, 8
            12, 23, 45, 51, 51, 8
            12, 23, 45, 45, 51, 8
            12, 23, 23, 45, 51, 8
            12, 18, 23, 45, 51, 8
             */
        }
        static void Sort(ref int[] ints)
        {
            int length = ints.Length;
            for (int i = 1; i < length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ints[j] > ints[j+1]) 
                    {
                        int temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j+1] = temp;
                    }
                }
            }
        }
    }
}