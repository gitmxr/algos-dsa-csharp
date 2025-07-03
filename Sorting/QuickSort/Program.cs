using CommonUtils;
using System;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randArray = Utils.GenRandArray();
            Console.WriteLine("unSorted Random Array!");
            Utils.PrintArray(randArray);
            Console.WriteLine("Sorted Array(QuickSort)!");
            Utils.PrintArray(QuickSort(randArray));


        }
        static int[] QuickSort(int[] arr)
           {
            if (arr.Length <= 1)
                return arr;

            Random random = new Random();
            int pivotIndex = random.Next(0, arr.Length);
            int pivot = arr[pivotIndex];

            List<int> Left = new List<int>();
            List<int> Right = new List<int>();
            List<int> Pivots = new List<int>();


            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < pivot)
                    Left.Add(arr[i]);
                else if (arr[i] > pivot)
                    Right.Add(arr[i]);
                else
                    Pivots.Add(arr[i]);
            }

            var sortedLeft = QuickSort(Left.ToArray());
            var sortedRight = QuickSort(Right.ToArray());

            return sortedLeft
                 .Concat(Pivots.ToArray())
                 .Concat(sortedRight)
                 .ToArray();
        }
    }
}
