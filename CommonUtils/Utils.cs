using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils
{
    public class Utils
    {
       public static int[] GenRandArray()
        {
            int[] randArray = new int[20];
            Random random = new Random();
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = random.Next(0, 20);
            }
            return randArray;
        }
       public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        public static int[] BubbleSort(int[] arr)
        {
            int[] sortedArr = (int[])arr.Clone();
            for (int i = 0; i < sortedArr.Length - 1; i++)
            {
                for (int j = 0; j < sortedArr.Length - i - 1; j++)
                {
                    if (sortedArr[j] > sortedArr[j + 1])
                    {
                        int temp = sortedArr[j];
                        sortedArr[j] = sortedArr[j + 1];
                        sortedArr[j + 1] = temp;
                    }
                }
            }
            return sortedArr;
        }
    }
}
