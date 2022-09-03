using System;
using System.Collections.Generic;

namespace StackDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //this algorithm is useful when you need to keep track of state. Uses LIFO, Last in First Out. and to get a specific Item you
            // to pop off items.
            //Stack<string> stack = new Stack<string>();
            //Console.WriteLine("Start Main");
            //stack.Push("main");
            //Console.WriteLine("Start RespondBuilder");
            //stack.Push("RespondBuilder");
            //Console.WriteLine("Start ExternalService");
            //stack.Push("CallExternalRespnder");
            //Console.WriteLine("End " + stack.Pop());

            //Console.WriteLine("Start ParseExternalData");
            //stack.Push("ParseExternalData");

            //Console.WriteLine("End " + stack.Pop());
            //Console.WriteLine("End " + stack.Pop());
            //Console.WriteLine("End " + stack.Pop());

            //stack.Peek()
            //stack.TryPeek: this check the state of the stack and returns a boolean

            int[] arr = new int[] { 12, 3, 4, 3, 2, 2 };
            int[] arr2 = new int[] { 2 };
            int[] arr3 = new int[] {2,3};
            int[] arr4 = new int[] { };

            //PrintNextGreaterelement(arr);
            //PrintNextGreaterelement(arr2);
            //PrintNextGreaterelement(arr3);
            //PrintNextGreaterelement(arr4);

            Console.WriteLine(HasMatchingParanthesis("((hello()))"));
            Console.WriteLine();
            Console.WriteLine(HasMatchingParanthesis("(hello("));
        }
        static void PrintNextGreaterelement(int[] arr)
        {
            if(arr.Length == 0)
            {
                return;
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(arr[0]);

            for(int i =1; i < arr.Length; i++)
            {
                int next = arr[i];
                if(stack.Count > 0)
                {
                    int popped = stack.Pop();
                    while(popped < next)
                    {
                        Console.WriteLine(popped+ "---->" + next);
                        if (stack.Count == 0)
                            break;
                        popped = stack.Pop();
                    }
                    if(popped > next)
                    {
                        stack.Push(popped);
                    }

                }
                stack.Push(next);
            }
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop() + "-->" + -1);
            }
        }

        static Boolean HasMatchingParanthesis(string s)
        {
            Stack<char> stack = new Stack<char>();
            for(int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if(current == '(')
                {
                    stack.Push(s[i]);
                    continue;
                }

                if(current == ')')
                {
                    if(stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        static Boolean HasMatchingParanthesis2(string s)
        {
            int matchingSymbolTracker = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if (current == '(')
                {
                    matchingSymbolTracker++;
                    continue;
                }

                if (current == ')')
                {
                    if (matchingSymbolTracker > 0)
                    {
                        matchingSymbolTracker--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return matchingSymbolTracker == 0;
        }
    }
}
