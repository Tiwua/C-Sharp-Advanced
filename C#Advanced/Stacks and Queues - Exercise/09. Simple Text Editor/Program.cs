using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            Stack<string> originalText = new Stack<string>();

            for (int i = 0; i < input; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];

                if (action == "1")
                {
                    originalText.Push(sb.ToString());
                    sb.Append(commands[1]);
                }
                else if (action == "2")
                {
                    originalText.Push(sb.ToString());

                    int charsToRemove = int.Parse(commands[1]);
                    sb.Remove(sb.Length - charsToRemove, charsToRemove);
                }
                else if (action == "3")
                {
                    int index = int.Parse(commands[1]);
                    char characterToLookFor = sb[index - 1];

                    Console.WriteLine(characterToLookFor);
                }
                else if (action == "4")
                {
                    sb.Clear();
                    sb.Append(originalText.Pop());
                }
            }
        }
    }
}