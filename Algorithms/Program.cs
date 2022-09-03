using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice fo GOOGLE BEGINS HERE!!!!!!!");

            // var maxNumber = MaxNumber(10, 18, 3);

            // Console.WriteLine("Maximum number is "+ maxNumber);
            //int[] a = { 1, 2, 3, 4, 5, 6 };
            //int item = 4;
            //Console.WriteLine(BinarySearch(a, item));
            LinkedList<string> list = new LinkedList<string>();
            //AddLast
            //AddFirst
            list.AddLast("Mike");
            list.AddLast("Lizz");
            list.AddLast("Esther");
            list.AddLast("Mawes");
            list.AddLast("Tosin");
            list.AddLast("Josh");

            Console.WriteLine(list.Contains("Lizz"));
            Console.WriteLine(list.Count);

            list.RemoveFirst();

            foreach(string item in list)
            {
                Console.WriteLine(item + "->");
            }

            Console.WriteLine();
        }

        //find max number

        public static int MaxNumber(int a, int b, int c)
        {
            int max = a;
            if(b > max)
            {
                max = b;
            }
            if(c > max)
            {
                max = c;
            }

            return max;
        }

        //validation algorithm
        static Boolean IsUppercase(string s)
        {
            return s.All(char.IsUpper);
        }

        static Boolean IsLowercase(string s)
        {
            return s.All(char.IsLower);
        }

        static Boolean IsPasswordComplexity(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }

        //Normalizing inputs 
        static string NormalizeString(string s)
        {
            return s.ToLower().Trim().Replace(",", "");
        }

        //searching for data within a string

        static void ParseString(string s)
        {
            Console.Write("Option 1");

            foreach(char c in s)
            {
                Console.WriteLine(c);
            }

            Console.Write("Option 2");

            for(int i =0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }
        }

        static Boolean IsAtEvenIndex(string s, char item)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            for(int i =0; i < s.Length/2+1; i = i + 2)
            {
                if(s[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        static string ReverseString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            StringBuilder reversed = new StringBuilder(s.Length);
            for(int i = s.Length -1; i >0; i--)
            {
                reversed.Append(s[i]);
            }

            return reversed.ToString();
        }

        static string ReverseWord(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder reverseWord = new StringBuilder();
            string[] arr = input.Split(" ");
            for(int i =0; i < arr.Length; i++) 
            {
                reverseWord.Append(ReverseString(arr[i]));
                if (i != arr.Length - 1)
                {
                    reverseWord.Append(" ");
                }
                
            }

            return reverseWord.ToString();
        }


        //Array Algorithm

        static int LinearSearch(int[] input, int n)
        {
            int item = Array.Find(input, element => element == n);

            return item;
        }

        //Binary Search
        static Boolean BinarySearch(int[] input, int item)
        {
            //since we know that this array is sorted
            int min = 0;
            int max = input.Length - 1;

            while(min <= max)
            {
                int mid = (min + max) / 2;
                if(item == input[mid])
                {
                    return true;
                }
                else if(item < input[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return false;
        }

        static Boolean BinarySearch2(int[] input, int item)
        {
            int i = Array.BinarySearch(input, item);
            if (i == item) return true;

            return false;
        }

        //collect even numbers from two arrays and merge into a single array

        static int[] FindEvenNumber(int[] arr1, int[] arr2)
        {
            ArrayList result = new ArrayList();
            foreach(int item in arr1)
            {
                if(item % 2 == 0)
                {
                    result.Add(item);
                }
            }

            foreach(int item in arr2)
            {
                if(item % 2 == 0)
                {
                    result.Add(item);
                }
            }

            return (int[])result.ToArray(typeof(int));
        }

        static int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];

            for(int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = arr[arr.Length - i - 1];
            }
            return reversed;
        }

        static int[] ReversedArrayInPlace(int[] arr)
        {
            for(int i = 0; i< arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }

            return arr;
        }

        static int[] RotateArrayLeft(int[] arr)
        {
            int temp = arr[0];
            for(int i =0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = temp;

            return arr;
        }

        static int[] RotateArrayRight(int[] input)
        {
            int temp = input[input.Length - 1];
            for(int i = input.Length-1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = temp;

            return input;
        }

        //linked list

        //class CustomLinkedList
        //{

        //    Node head;
        //    public class Node
        //    {
        //        public int data;
        //        public Node next;

        //        public Node(int d) { data = d; }
        //    }
        //}

    }
}
