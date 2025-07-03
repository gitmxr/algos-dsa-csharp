using CommonUtils;
namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNo = Utils.GenRandArray();
            Console.WriteLine("Unsorted Array:");
            Utils.PrintArray(randomNo);
            BubbleSort(randomNo);
            Console.WriteLine("\nSorted Array(Bubble-Sort)");
            Utils.PrintArray(randomNo);
        }
        static void BubbleSort(int[] arr)
        { 
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    { 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }
    }
}