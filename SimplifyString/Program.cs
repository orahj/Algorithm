using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplifyString
{
    class Program
    {
        //static string simplify(string path ="")
        //{
        //    Stack<char> v = new Stack<char>();
        //    int n = path.Length;
        //    var res = "/";
        //    for(int i = 0; i < n; i++)
        //    {
        //        if(path[i] != '/' && path[i] != '.')
        //        {
        //            v.Push(path[i]);
        //            continue;
        //        }

        //        if(path[i] == '.')
        //        {
        //            if(i+1 < path.Length)
        //            {
        //                if (path[i + 1] == '.')
        //                    v.Pop();
        //            }
        //        }
        //    }
        //    if(v.Count > 0)
        //    {
        //        char r = v.Pop();
        //        res += r;
        //    }

        //    return res;
        //}
        static string simplify(string path = "/a/./b/../../c////////..")
         {
            var temp = "";
            if(path[path.Length-1]!= '/')
            {
                path += "/";
            }
            Stack<string> st = new Stack<string>();
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == '/')
                {
                    if (!string.IsNullOrEmpty(temp))
                    {
                        if (temp == "/." || temp[temp.Length - 1] == '/')
                        {
                            temp = "/";
                            continue;
                        }
                        else if (temp == "/..")
                        {
                            if (st.Count > 0) st.Pop();
                            temp = "/";
                        }
                        else
                        {
                            st.Push(temp);
                        }
                    }
                    temp = "/";
                    continue;
                }
                else
                {
                    temp += path[i];
                    continue;
                }
            }
            var newPath = "";
            if(st.Count > 0)
            {
                newPath += st.Pop();
            }
            Console.WriteLine(newPath);
            return newPath;
        }

        //static string simplify2(string path = "/a/./b/../../c/")
        //{
        //    Stack<char> st = new Stack<char>();
        //    StringBuilder sb = new StringBuilder();
        //    List<string> pb = new List<string>();
        //    var sp = path.Split("/");
        //    for(int i =0; i < sp.Length; i++)
        //    {
        //        if(sp[i] == ".")
        //    }
        //}

        public static long diagonalDifference(List<List<int>> arr)
        {
         int result = 0;
        long leftToRight = 0;
        long rightToLeft = 0;
            int n = arr.Count();
            for (int i = 0; i < n; i++)
            {
                leftToRight += Convert.ToInt64(arr[i][i]);
            }
            for (int i = 0; i < n; i++)
            {
                rightToLeft += Convert.ToInt64(arr[((n - 1) - i)][ i]);
            }
            result = (int)(leftToRight - rightToLeft);
            return Math.Abs(result);
        }

        public static int diagonalDifference1(List<List<int>> arr)
        {
            int result = 0;
            long leftToRight = 0;
            long rightToLeft = 0;
            int n = arr.Count();
            for (int i = 0; i < n; i++)
            {
                leftToRight += Convert.ToInt64(arr[i][i]);
            }
            for (int i = 0; i < n; i++)
            {
                rightToLeft += Convert.ToInt64(arr[((n - 1) - i)][i]);
            }
            result = (int)(leftToRight - rightToLeft);
            return  Math.Abs(result);
        }

        public static List<int> minimalHeaviestSetA(List<int> arr)
        {
            List<int> res = new List<int>();

            //sort array
            arr.Sort();
            int num = arr.Count;

            List<int> first = new List<int>();
            List<int> second = new List<int>();

            for(int i =0; i < num/2; i++)
            {
                first.Add(arr[i]);
            }

            for(int i = num/2; i < num; i++)
            {
                second.Add(arr[i]);
            }
            Console.WriteLine(res);
            return res;
        }
        static void Main(string[] args)
        {
            //simplify();
            //Console.WriteLine("Next=========================>");
            //List<List<int>> arr = new List<List<int>>();
            //List<int> first = new List<int> { 1, 2, 3 };
            //List<int> second = new List<int> { 4, 5, 6 };
            List<int> third = new List<int> { 7,10,2, 8, 9 };
            //arr.Add(first);
            //arr.Add(second);
            //arr.Add(third);
            //diagonalDifference(arr);



            //Console.ReadLine();

            closestNumbers(third);
        }
        public static void closestNumbers(List<int> numbers)
        {
            int min_Diff = Int32.MaxValue;
            numbers.Sort();
            for (int i = 1; i < numbers.Count(); i++)
            {
                min_Diff = Math.Min(numbers[i] - numbers[i - 1], min_Diff);
            }
            for (int i = 1; i < numbers.Count(); i++)
            {
                if (min_Diff == numbers[i] - numbers[i - 1])
                {
                    Console.Write(numbers[i - 1]);
                    Console.Write(' ');
                    Console.Write(numbers[i]);
                    Console.Write(' ');
                }
            }
        }

        public static void plusMinus(List<int> arr)
        {
            arr.Sort();
            float n = 0f;
            n = arr.Count();
            float p = 0f, ng = 0f, z = 0f;
            float positiveRatio = 0f;
            float negativeRatio = 0f;
            float zeroRation = 0f;

            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] > 0)
                {
                    p++;
                }
                else if (arr[i] < 0)
                {
                    ng++;
                }
                else
                {
                    z++;
                }
            }
            positiveRatio = (p / n);
            negativeRatio = (ng / n);
            zeroRation = (z / n);
            Console.WriteLine(positiveRatio.ToString("N6"));
            Console.WriteLine(negativeRatio.ToString("N6"));
            Console.WriteLine(zeroRation.ToString("N6"));
        }
    }
}
