using CommonUtils;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randArray = Utils.GenRandArray();
         
            //int[] randArray = {2,1,2,4,3,5};

            Console.WriteLine("Unsorted Array:");
            Utils.PrintArray(randArray);
            Console.WriteLine("\nSorted Array(MergeSort):");
            var SortedArray =  MergeSort(randArray);
            Utils.PrintArray(SortedArray);
            Console.ReadLine();
        }

        static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            int mid = arr.Length / 2;

            // I can implement this using Linq (usign this the left and right array will be directly filled)

            //int[] left = arr.Take(mid).ToArray();   // First half
            //int[] right = arr.Skip(mid).ToArray();  // Second half

            // I can implement this using List 

            //List<int> Left = new List<int>();
            //List<int> Right = new List<int>();

            // I can Implement this using direct array intitailization
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            // To fill the list Left and Right

            //for (int i = 0; i < mid; i++)
            //{
            //    Left.Add(arr[i]);
            //}
            //for (int j = mid; j < arr.Length; j++)
            //{
            //    Right.Add(arr[j]);
            //}

            //int[] sortedLeft = MergeSort(Left.ToArray());     // Recursively sort left
            //int[] sortedRight = MergeSort(Right.ToArray());   // Recursively sort right

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int j = mid; j < arr.Length ; j++)
            {
                right[j - mid] = arr[j];  
            }

            int[] sortedLeft = MergeSort(left);     // Recursively sort left
            int[] sortedRight = MergeSort(right);   // Recursively sort right

            return Merge(sortedLeft, sortedRight);  // Merge the sorted halves
        }


        static int[] Merge(int[] left, int[] right)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            // Add any remaining elements
            while (i < left.Length) result.Add(left[i++]);
            while (j < right.Length) result.Add(right[j++]);

            return result.ToArray();
        }
    }
}
