int[] bubble = new int[] { 8, 5, 7, 3, 2 };
BubbleSort(ref bubble);
void Swap(ref int first, ref int second)
{
    int temp = first;
    first = second;
    second = temp;
}
void BubbleSort(ref int[] bubble)
{
    int length = bubble.Length;
    for (int k = 0; k < length - 1; k++) 
    {
        for (int i = 0; i < length - 1; i++)
        {
            if (bubble[i] > bubble[i + 1])
            {
                Swap(ref bubble[i], ref bubble[i + 1]);
            }
        }
    }

    for (int i = 0; i < bubble.Length; i++)
    {
        Console.WriteLine(bubble[i]);
    }
}