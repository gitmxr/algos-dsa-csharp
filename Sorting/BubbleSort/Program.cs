using CommonUtils;
namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNo = Utils.GenRandArray();
            //int[] randomNo = { 22, 33, 22, 55, 77, 66, 44, 88 };

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
                bool swaped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swaped = true;
                    }
                }
                if (!swaped)
                    break;
            }


        }
    }
}

// hard run 
//13 1 9 6 0 19 17 19  origanl array(length = 8 , u need max 7 passes to guranted sorting)
// 1 9 6 0 13 17 19 19   i =0 (largest is sorted)
// 1 6 0 9 13 17 19 19   i=1  (second largest )
// 1 0 6 9 13 17 19 19   i=2  (3rd largest)
// 0 1 6 9 13 17 19 19   i=3   (4th and onward) it will continue till seven passed but fortunately we got sorted arry here 