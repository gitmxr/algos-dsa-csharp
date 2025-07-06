using CommonUtils;

namespace DeletionFromEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randArr = Utils.GenRandArray();
            //int[] randArr = {11,22,33,44,55,66,77,88,99,100};
            int size = randArr.Length;
            Console.WriteLine("Array Before Deletion:");
            PrintArray(randArr, size);
            size = DeletionFromEnd(randArr, size);
            if (size > 0)
            {
                Console.WriteLine("\nArray After Deletion From Last: ");
                PrintArray(randArr, size);
            }
            else
            {
                Console.WriteLine("\nArray is empty after deletion.");
            }

        }
        static int DeletionFromEnd(int[] randArr,int size)
        {
            if (size == 0)
            {
                Console.WriteLine("Array is Already empty! can't delete any other Item");
                return 0;
            }
            randArr[size - 1] = 0;

            return size - 1;
        }

        static void PrintArray(int[] randArr, int size)
        {
            if (size == 0)
            {
                Console.WriteLine("array has no element to display!");
                return;
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(randArr[i]+" ");
            }
        }


    }
}
