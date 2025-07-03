using CommonUtils;

namespace BinarySearching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randArray = CommonUtils.Utils.GenRandArray();
            int[] sortedArray = Utils.BubbleSort(randArray);
            Console.WriteLine("A Sorted Array:");
            Utils.PrintArray(sortedArray);
            Console.Write("\nEnter the Element U wanna Find! ");
            int target = int.Parse(Console.ReadLine()!);
            int index = BinarySearch(sortedArray, target);

            if (index != -1)
                Console.WriteLine($"Element found through BinarySearch at index {index}");
            else
                Console.WriteLine("Element not found.");
        }

        static int BinarySearch(int[] arr,int target) 
        {
            int low = 0;
            int high = arr.Length - 1;  
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (target == arr[mid])
                {
                    return mid;
                }
                else if (target < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;

                }
            }
            return -1;

        }
    }
}
