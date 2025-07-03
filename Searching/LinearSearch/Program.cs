using CommonUtils;
using System.Linq.Expressions;

namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Array Elements:");
            int[] arr = Utils.GenRandArray();
            Utils.PrintArray(arr);
            Console.Write("\nEnter the Element U Wanna Find!:");
            int Target = int.Parse(Console.ReadLine()!);
            List<int> indicesFound =  LinearSearch(arr,Target);
            if (indicesFound.Count == 0)
            {
                Console.WriteLine("Element not Found in the arary");
            }
            else
            {
                Console.WriteLine("Element Found At Indices:" + string.Join(", ", indicesFound));
            }

        }
        static List<int> LinearSearch(int[] arr, int Target)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == Target)
                {
                    indices.Add(i);
                }            
            }
            return indices;
        }
    }
}
