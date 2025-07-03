using CommonUtils;
namespace InsertionAtStart
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
            int[] updatedArray = InsertionAtStart(OG_Array, valueToInsert);
            Console.WriteLine("\nArray After Insertion:");
            Utils.PrintArray(updatedArray);
            Console.ReadLine();
        }
        static int[] InsertionAtStart(int[] arr,int valueToInsert)
        {
            int[] newArr = new int[arr.Length+1];
            newArr[0] = valueToInsert;
            for (int i = 1; i < newArr.Length; i++) 
            {
                newArr[i] = arr[i-1];
            }
            return newArr;
        }
    }
}
