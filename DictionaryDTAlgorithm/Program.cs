using System;
using System.Collections.Generic;

namespace DictionaryDTAlgorithm
{
    class Program
    {
        static void displayFrequencyOfElement(int[] arr)
        {
            Dictionary<int, int> elementFreq = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if (elementFreq.ContainsKey(arr[i]))
                {
                    elementFreq[arr[i]]++;
                }
                else
                {
                    elementFreq[arr[i]] = 1;
                }
            }

            foreach(KeyValuePair<int,int> x in elementFreq)
            {
                Console.WriteLine(x.Key + " ==> " + x.Value);
            }
        }
        static void Main(string[] args)
        {
            displayFrequencyOfElement(new int[] { 2, 2, 3, 4, 5, 3, 3, 2, 2, 5, 6, 5, 4, 4, 4, 5, 5, 6, 7, 5, 4, 4, 5, 8, 7, 7, 8, 9 });
        }
    }
}
