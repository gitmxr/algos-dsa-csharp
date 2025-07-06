using CommonUtils;

namespace DeletionByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randArr = Utils.GenRandArray();
            //int[] randArr = { 11, 22, 33, 44, 55, 66, 77 };
            Console.WriteLine("Orignal Array: ");
            Utils.PrintArray(randArr);
            Console.Write("\nEnter the Value you want to delete: ");
            int value = int.Parse(Console.ReadLine()!);
            int[] updatedArr = DeleteByValue(randArr,value);
            Utils.PrintArray(updatedArr);   
        }
        static int[] DeleteByValue(int[] arr, int value)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                   index = i;
                    break;
                }
            }
            if(index == -1)
            {
                Console.WriteLine("value not found");
                return arr;
            }
            //int[] newArr = new int[arr.Length -1];
            //for (int i = 0;i < index; i++)
            //{
            //    newArr[i] = arr[i];
            //}
            //for (int i = index;i < arr.Length -1; i++)
            //{
            //    newArr[i] = arr[i + 1];
            //}
            //return newArr;

            int[] newArr = new int[arr.Length - 1];
            Array.Copy(arr, 0, newArr, 0, index);
            Array.Copy(arr, index + 1, newArr, index, arr.Length - index - 1);
            return newArr;
        }
    }
}
