using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int pushElements = int.Parse(input[0]);
            int popElement = int.Parse(input[1]);
            int neededElement = int.Parse(input[2]);

            int[] elements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < pushElements; i++)
            {
                if (i < elements.Length)
                {
                    stack.Push(elements[i]);
                }
            }

            for (int i = 0; i < popElement; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            if (stack.Contains(neededElement))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}