using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionAtSpecificIndex
{
    internal class Utils
    {
        public static int[] GenerateArray()
        {
            Random random = new Random();
            int[] array = new int[15];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 16);
            }
            return array;
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
