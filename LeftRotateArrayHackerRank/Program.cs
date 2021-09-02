using System;

namespace LeftRotateArrayHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of digits in array & No of rotation");
            string[] tokens_n = Console.ReadLine().Split(' ');
            int numberOfInts = Convert.ToInt32(tokens_n[0]);
            int rotations = Convert.ToInt32(tokens_n[1]);
            Console.WriteLine("Enter the array");
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] output = new int[numberOfInts];
            int realRotations = rotations >= numberOfInts ? rotations % numberOfInts : rotations;

            // 4 == { 1, 2, 3, 4, 5 } => { 5, 1, 2, 3, 4 }
            // 2 == { 1, 2, 3, 4, 5 } => { 3, 4, 5, 1, 2}
            for (int i = 0; i < numberOfInts; i++)
            {
                int newIndex = i + realRotations;
                if (newIndex >= numberOfInts)
                    newIndex = newIndex % numberOfInts;
                output[i] = a[newIndex];
            }

            Console.WriteLine(string.Join(" ", output));
            Console.Read();
        }
    }
}
