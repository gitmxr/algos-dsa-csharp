using CommonUtils;
namespace DeletionFromBegining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randArr = Utils.GenRandArray();
            Console.WriteLine("Array Before Deletion:");
            Utils.PrintArray(randArr);
            int[] UpdatedArr = DeletionFromBegining(randArr);
            Console.WriteLine("\nArray After Deletion From Begining:");
            Utils.PrintArray(UpdatedArr);
        }
        static int[] DeletionFromBegining(int[] randArr)
        {
            if (randArr.Length == 0)
            {
                Console.WriteLine("Array is already empty. Cannot delete.");
                return randArr;
            }
            int[] newArr = new int[randArr.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = randArr[i+1];
            }
            return newArr;
        }
    }
}
