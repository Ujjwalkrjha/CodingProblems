using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence to reverse.");
            string seq = Console.ReadLine();
            Console.WriteLine("The reverse is {0}.",ReverseString(seq));
            Console.ReadLine();
        }
        public static string ReverseString(string sequence)
        {
            ////METHOD 1 - Using internal functions
            //char[] array = sequence.ToCharArray();
            //Array.Reverse(array);
            //string revarray = new string(array);
            //return revarray;

            //METHOD 2 - Using loop
            int Length = sequence.Length - 1;
            string reverse = "";
            while (Length >= 0)
            {
                reverse += sequence[Length];
                Length--;
            }
            return reverse;
        }
    }
}
