using System;
using System.Collections.Generic;
namespace HashSetAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static List<int> FindMissingElements(int[]arr1, int[] arr2)
        {
            List<int> missingElements = new List<int>();
            HashSet<int> secondArray = new HashSet<int>();

            foreach(int item in arr1)
            {
                secondArray.Add(item);
            }

            foreach(int item in arr2)
            {
                if (!secondArray.Contains(item))
                {
                    missingElements.Add(item);
                }
            }

            return missingElements;
        }
    }
}
