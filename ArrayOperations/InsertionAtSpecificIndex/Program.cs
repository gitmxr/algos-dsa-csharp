using System;
using CommonUtils;

namespace InsertionAtSpecificIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] OG_Array = Utils.GenRandArray();
            Console.WriteLine("Array before Insertion:");
            Utils.PrintArray(OG_Array);
            Console.Write("\nEnter value To Insert: ");
            int valueToInsert = int.Parse(Console.ReadLine()!);
            Console.Write("\nEnter Index for value To Insert at: ");
            int Index = int.Parse(Console.ReadLine()!);
            int[] updatedArray = InsertionAtSpecificIndex(OG_Array,valueToInsert,Index);
            Console.WriteLine("\nArray After Insertion:");
            Utils.PrintArray(updatedArray);
            Console.ReadLine(); 
        }
       static int[] InsertionAtSpecificIndex(int[] arr,int valueToInsert, int Index)
        {
            if (Index < 0 || Index > arr.Length)
            {
                Console.WriteLine("Invalid index.");
                return arr;
            }
            int[] newArr = new int[arr.Length+1];
            for(int i =0; i < arr.Length;i++)
            {
                newArr[i] = arr[i];
            }
                    for (int j = newArr.Length - 1; j > Index; j--)
                    {
                        newArr[j] = newArr[j - 1];
                    }
                    newArr[Index] = valueToInsert;
            return newArr;
        }

    }
}
