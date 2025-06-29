using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Utils
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
    }
}
