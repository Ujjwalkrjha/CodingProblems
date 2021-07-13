using System;
using System.Linq;

namespace MinimumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers");
            int[] seq = new int[n];
            string phrase = Console.ReadLine();
            string[] number = phrase.Split(' ');
            for (int i = 0; i < n; i++)
            {
                seq[i] = int.Parse(number[i]);
            }
            Console.WriteLine(Minimum(seq));
            Console.ReadLine();
        }
        public static int Minimum(int[] sequence)
        {
            int Length = sequence.Length - 1;
            int result = sequence[0];
            for (int i = 0; i <= Length; i++)
            {
                if (sequence[i] < result)
                    result = sequence[i];
            }
            return result;
        }
    }
}