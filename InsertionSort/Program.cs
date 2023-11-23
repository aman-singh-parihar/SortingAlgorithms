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