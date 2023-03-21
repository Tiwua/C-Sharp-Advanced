using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> boxes = new Stack<int>(clothes);

            int countOfRacks = 0;

            while (boxes.Count > 0)
            {
                int currentRack = 0;
                while (boxes.Count > 0 && currentRack + boxes.Peek() <= rackCapacity)
                {
                    currentRack += boxes.Pop();
                }

                countOfRacks++;
            }

            Console.WriteLine(countOfRacks);
        }
    }
}