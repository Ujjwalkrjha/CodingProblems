using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the array");
            int[] seq = new int[n];
            for (int i = 0; i < n; i++)
            {
                seq[i] = Convert.ToInt32(Console.ReadLine());
            }
            ReverseArray(seq);
        }
        public static int[] ReverseArray(int[] sequence)
        {
            int Length = sequence.Length - 1;
            int[] reverse = new int[Length] ;
            while (Length >= 0)
            {
                for(int i =0;i<=Length;i++)
                {
                    reverse[i] = sequence[Length];
                    Length--;
                    Console.WriteLine(reverse[i]);
                }

            }


            Console.ReadLine();
            return reverse;
        }
    }
}

