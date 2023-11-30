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
12, 45, 23, 51, 18, 8   12, 45, 23, 51, 18, 8   12, 23, 45, 51, 18, 8   12, 23, 45, 51, 18, 8

---1st iteration---     ----2nd iteration---    ----3rd iteration----   ---4th iteration---
i = 1, j = 0            i = 2, j = 1                                    i = 4, j = 3
ints[i] => 45 => key    ints[i] => 23 => key                            ints[i] => 18 => key
ints[j] => 12           ints[j] => 45                                   ints[j] => 51
12, 45, 23, 51, 18, 8   12, 45, 45, 51, 18, 8                           12, 23, 45, 51, 51, 8
                        12, 23, 45, 51, 18, 8                           
                                                                        j => 2
                                                                        ints[j] => 45  
                                                                        12, 23, 45, 45, 51, 8
*/
        }
        static void Sort(ref int[] ints)
        {
            int length = ints.Length;
            for (int i = 1; i < length; i++)
            {
                int j = i - 1;
                int key = ints[i];
                while (j >= 0 && ints[j] > key) 
                {
                    ints[j+1] = ints[j];
                    j--;
                }
                ints[j + 1] = key;
            }
        }
    }
}