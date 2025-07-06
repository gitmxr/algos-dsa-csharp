using CommonUtils;

namespace DeletionFromSpecificIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randArr = Utils.GenRandArray();
            //int[] randArr = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100 };
            Console.WriteLine("Array Before Deletion:");
            Utils.PrintArray(randArr);
            Console.Write("\nEnter the Index of Element You Want To Delete: ");
            int index = int.Parse(Console.ReadLine()!);
            if (index < 0 || index >= randArr.Length)
            {
                Console.WriteLine("❌ Invalid index! No deletion performed.");
                return;
            }
            Console.WriteLine("\nArray after Deletion:");
            int[] updatedArr = DeletionFromSpecificIndex(randArr,index);
            Utils.PrintArray(updatedArr);
        }
        static int[] DeletionFromSpecificIndex(int[] randArr, int index)
        {
            int[] newArr = new int[randArr.Length - 1];

            for (int i = 0; i<index; i++)
            {
                newArr[i] = randArr[i]; 
            }
            for (int i = index +1; i < randArr.Length; i++)
            {
                newArr[i - 1] = randArr[i];
            }

            return newArr;
        }
    }
}
