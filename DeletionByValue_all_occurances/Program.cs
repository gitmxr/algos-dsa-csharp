using CommonUtils;
using System.Linq.Expressions;

namespace DeletionByValue_all_occurances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randArr = Utils.GenRandArray();
            //int[] randArr = { 11,22,22,33,22};
            Console.WriteLine("Orignal Array: ");
            Utils.PrintArray(randArr);
            Console.Write("\nEnter the Value you want to delete: ");
            int value = int.Parse(Console.ReadLine()!);
            int[] updatedArr = DeleteByValue_all_occurances(randArr, value);
            Utils.PrintArray(updatedArr);
        }
        static int[] DeleteByValue_all_occurances(int[] arr, int value)
        {
            int count = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == value)
                {
                    count++;    
                }
            }
            if (count == 0)
            {
                Console.WriteLine("value not found!");
                return arr;
            }
            int[] newArr = new int[arr.Length - count]; 
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != value)
                {
                    newArr[j] = arr[i];
                    j++;
                }
                      
            }
            return newArr;
        }
    }
}
  