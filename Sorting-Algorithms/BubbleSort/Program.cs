
namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNo = new int[100];
            Random random = new Random();
            for (int i = 0; i < randomNo.Length; i++)
            {
                randomNo[i] = random.Next(60, 101);
            }
            Console.WriteLine("Unsorted Array:");
            PrintArray(randomNo);
            BubbleSort(randomNo);
            Console.WriteLine("\nSorted Array");
            PrintArray(randomNo);
        }
       static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
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