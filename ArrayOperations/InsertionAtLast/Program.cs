using CommonUtils;

namespace InsertionAtLast
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
            int[] updatedArray = InsertionAtLast(OG_Array, valueToInsert);
            Console.WriteLine("\nArray After Insertion:");
            Utils.PrintArray(updatedArray);
            Console.ReadLine();
        }

        static int[] InsertionAtLast(int[] arr, int valueToInsert)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = valueToInsert;

            return newArr;
        }
    }
}
